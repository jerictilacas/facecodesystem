using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO;
using System.Drawing.Imaging;
using System.Xml;
using System.Threading;




namespace curfew
{
    public partial class recorduc : UserControl
    {
        
        #region variables
        Image<Bgr, Byte> currentFrame; //current image aquired from webcam for display
        Image<Gray, byte> result, TrainedFace = null; //used to store the result image and trained face
        Image<Gray, byte> gray_frame = null; //grayscale current image aquired from webcam for processing

        Capture grabber; //This is our capture variable

        public CascadeClassifier Face = new CascadeClassifier(Application.StartupPath + "/Cascade/haarcascade_frontalface_alt2.xml");//Our face detection method 

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5); //Our font for writing within the frame

        //Classifier with default training location
        Classifier_Train Eigen_Recog = new Classifier_Train();
        string name = "";

        #endregion

        bool test1 = true;
        
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MinorInformation;Integrated Security=True";

        string id = "", dbage = "", dbgender = "", dbaddress = "", dbcontact = "", dboffence = "", dbdate = "";


        private static recorduc _instance;
            
        public static recorduc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new recorduc();
                return _instance;
            }
        }
        
        public recorduc()
        {
            InitializeComponent();
        }

        public void initialize_capture()
        {
            grabber = new Capture(1);
            grabber.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber_Parallel);
            Eigen_Recog.Recognizer_Type = "EMGU.CV.LBPHFaceRecognizer";
            Eigen_Recog.Retrain();
            Eigen_Recog.Set_Eigen_Threshold = Math.Abs(Convert.ToInt32("4000"));

        }

        public void stop_capture()
        {
            grabber = new Capture(1);
            grabber.Stop();
        }

        //Process Frame
        void FrameGrabber_Standard(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(420, 340, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            if (currentFrame != null)
            {
                gray_frame = currentFrame.Convert<Gray, Byte>();

                //Face Detector
                Rectangle[] facesDetected = Face.DetectMultiScale(gray_frame, 1.2, 10, new Size(50, 50), Size.Empty);

                //Action for each element detected
                for (int i = 0; i < 1; i++)// (Rectangle face_found in facesDetected)
                {
                    //This will focus in on the face from the haar results its not perfect but it will remove a majoriy
                    //of the background noise
                    facesDetected[i].X += (int)(facesDetected[i].Height * 0);
                    facesDetected[i].Y += (int)(facesDetected[i].Width * 0);
                    facesDetected[i].Height -= (int)(facesDetected[i].Height * 0);
                    facesDetected[i].Width -= (int)(facesDetected[i].Width * 0);

                    result = currentFrame.Copy(facesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    result._EqualizeHist();
                    //image_PICBX.Image = result.ToBitmap();
                    //draw the face detected in the 0th (gray) channel with blue color
                    currentFrame.Draw(facesDetected[i], new Bgr(Color.Red), 2);

                    if (Eigen_Recog.IsTrained)
                    {
                        string name = Eigen_Recog.Recognise(result);
                        int match_value = (int)Eigen_Recog.Get_Eigen_Distance;

                        //Draw the label for each face detected and recognized
                        currentFrame.Draw(name + " ", ref font, new Point(facesDetected[i].X - 2, facesDetected[i].Y - 2), new Bgr(Color.LightGreen));
                        ADD_Face_Found(result, name, match_value);
                    }
                }
                //Show the faces procesed and recognized
                image_PICBX.Image = currentFrame;
            }
        }

        int xyz = 0;
        int[] offenceCollectionCount = new int[99];

        void FrameGrabber_Parallel(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            try
            {
                currentFrame = grabber.QueryFrame().Resize(420, 340, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            }
            catch
            {

            }
            //Convert it to Grayscale
            //Clear_Faces_Found();

            if (currentFrame != null)
            {
                gray_frame = currentFrame.Convert<Gray, Byte>();
                //Face Detector
                Rectangle[] facesDetected = Face.DetectMultiScale(gray_frame, 1.2, 10, new Size(50, 50), Size.Empty);

                //Action for each element detected
                Parallel.For(0, 1, i =>
                {
                    try
                    {
                        facesDetected[i].X += (int)(facesDetected[i].Height * 0); // 0.15
                        facesDetected[i].Y += (int)(facesDetected[i].Width * 0); // 0.22
                        facesDetected[i].Height -= (int)(facesDetected[i].Height * 0); // 0.3
                        facesDetected[i].Width -= (int)(facesDetected[i].Width * 0); // 0.35

                        result = currentFrame.Copy(facesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        result._EqualizeHist();
                        //draw the face detected in the 0th (gray) channel with blue color
                        currentFrame.Draw(facesDetected[i], new Bgr(Color.Red), 2);
                        if (Eigen_Recog.IsTrained)
                        {
                            Eigen_Recog.Recognizer_Type = "EMGU.CV.FisherFaceRecognizer";
                            Eigen_Recog.Retrain();
                            if (Eigen_Recog.IsTrained)
                            {
                                Eigen_Recog.Recognizer_Type = "EMGU.CV.EigenFaceRecognizer";
                                Eigen_Recog.Retrain();
                                if (Eigen_Recog.IsTrained)
                                {
                                    Eigen_Recog.Recognizer_Type = "EMGU.CV.LBPHFaceRecognizer";
                                    Eigen_Recog.Retrain();

                                    name = Eigen_Recog.Recognise(result);
                                    int match_value = (int)Eigen_Recog.Get_Eigen_Distance;

                                    //Draw the label for each face detected and recognized
                                    currentFrame.Draw(name + " ", ref font, new Point(facesDetected[i].X - 2, facesDetected[i].Y - 2), new Bgr(Color.LightGreen));
                                    ADD_Face_Found(result, name, match_value);

                                    Application.Idle -= new EventHandler(FrameGrabber_Standard);

                                    if (name != "Unknown")
                                    {

                                        int nameCount = name.Length - 1;
                                        string[] nameSplit = name.Trim().Split(' ');
                                        string lastname = nameSplit[nameSplit.Length - 1];
                                        int lnameCount = nameCount - lastname.Length;
                                        string firstname = name.Remove(lnameCount).TrimEnd();

                                        /**
                                         * > fetch data using lname and fname
                                         * > display value
                                         * **/

                                        using (SqlConnection con = new SqlConnection(connectionString))
                                        {

                                            SqlCommand cmd = new SqlCommand("SELECT * FROM minor_record WHERE LastName = @lname AND FirstName = @fname", con);


                                            con.Open();

                                            cmd.Parameters.AddWithValue("@lname", lastname);
                                            cmd.Parameters.AddWithValue("@fname", firstname);

                                            SqlDataReader reader = cmd.ExecuteReader();
                                            if (reader.HasRows)
                                            {
                                                if (reader.Read())
                                                {
                                                    id = reader["minorID"].ToString();
                                                    firstname = reader["FirstName"].ToString();
                                                    lastname = reader["LastName"].ToString();
                                                    dbage = reader["Age"].ToString();
                                                    dbgender = reader["Gender"].ToString();
                                                    dbaddress = reader["Address"].ToString();
                                                    dbcontact = reader["Contact"].ToString();
                                                    dboffence = reader["Offence"].ToString();
                                                    dbdate = reader["Date"].ToString();


                                                    groupBox1.Visible = true;
                                                    lname.Text = lastname;
                                                    fname.Text = firstname;
                                                    age.Text = dbage;
                                                    gender.Text = dbgender;
                                                    address.Text = dbaddress;
                                                    contact.Text = dbcontact;

                                                    offenceCollectionCount[xyz] = Int32.Parse(dboffence) + 1;

                                                    string offenceCount = "";

                                                    switch (offenceCollectionCount[0])
                                                    {
                                                        case 1:
                                                            offenceCount = "1st";
                                                            break;
                                                        case 2:
                                                            offenceCount = "2nd";
                                                            break;
                                                        case 3:
                                                            offenceCount = "3rd";
                                                            break;
                                                        default:
                                                          offenceCount = offenceCollectionCount[0].ToString() + "th";
                                                            break;
                                                    }

                                                    information.Text = name + " has committed the " + offenceCount + " " + "offense!";

                                                    xyz = xyz + 1;

                                                    stop_capture();
                                                }
                                            }
                                            reader.Close();
                                            con.Close();
                                        }
                                    }

                                    else if (name == "Unknown")
                                    {
                                        if (test1)
                                        {
                                            MessageBox.Show("No records found. Please add new record!");
                                            test1 = false;
                                            grabber.Stop();
                                        }

                                        this.adduc1.Visible = true;
                                        groupBox1.Visible = false;
                                        this.recbuttompanel.Visible = false;
                                    }
                                    else
                                    {
                                        this.adduc1.Visible = false;
                                        this.recbuttompanel.Visible = true;
                                    }

                                    if (grabber != null)
                                    {
                                        grabber.Dispose();
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        //do nothing as parrellel loop buggy
                        //No action as the error is useless, it is simply an error in 
                        //no data being there to process and this occurss sporadically 
                    }
                });
                //Show the faces procesed and recognized
                image_PICBX.Image = currentFrame;
            }
        }


        void updateOffenceCount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    int OffenceCount = Int32.Parse(dboffence);
                    OffenceCount = OffenceCount + 1;

                    SqlCommand sqlCmd = new SqlCommand("Update minor_record SET Offence = @offence, Date = @date where minorID = '" + id + "'", con);
                    sqlCmd.Parameters.AddWithValue("@offence", OffenceCount);
                    sqlCmd.Parameters.AddWithValue("@date", DateTime.Now);
                    sqlCmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {

            }
        }

        void ADD_Face_Found(Image<Gray, Byte> img_found, string name_person, int match_value)
        {
            PictureBox PI = new PictureBox();
            PI.SizeMode = PictureBoxSizeMode.StretchImage;
            PI.Image = img_found.ToBitmap();
            Label LB = new Label();
            LB.Text = name_person + " " + match_value.ToString();
            //LB.Width = 80;
            LB.Height = 15;
        }

        public void checkProps()
        {
            this.name = "";
            this.image_PICBX.Image = null;
            this.adduc1.Visible = false;
            this.recbuttompanel.Visible = true;
            this.Refresh();
        }

        private void recorduc_Load(object sender, EventArgs e)
        {
            this.adduc1.Visible = false;
            this.recbuttompanel.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void adduc1_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void contact1_Click(object sender, EventArgs e)
        {

        }

        private void age1_Click(object sender, EventArgs e)
        {

        }

        private void information_Click(object sender, EventArgs e)
        {
            
        }

        private void fname_Click(object sender, EventArgs e)
        {

        }
        //########################################################################################
        //iTexmo API for C# / ASP --> go to www.itexmo.com/developers.php for API Documentation
        //########################################################################################
        public object itexmo(string Number, string Message, string API_CODE)
        {
            object functionReturnValue = null;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection parameter = new System.Collections.Specialized.NameValueCollection();
                string url = "https://www.itexmo.com/php_api/api.php";
                parameter.Add("1", Number);
                parameter.Add("2", Message);
                parameter.Add("3", API_CODE);
                dynamic rpb = client.UploadValues(url, "POST", parameter);
                functionReturnValue = (new System.Text.UTF8Encoding()).GetString(rpb);
            }
            return functionReturnValue;
        }

        

        //########################################################################################
        //API END     '###########################################################################
        //########################################################################################
        private void Capture_Click(object sender, EventArgs e)
        {
            initialize_capture();
            
        }

        private void lname1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            initialize_capture();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Age_Click(object sender, EventArgs e)
        { 

        }

        private void Lname_Click(object sender, EventArgs e)
        {

        }

        private void Address1_Click(object sender, EventArgs e)
        {

        }

        private void Gender1_Click(object sender, EventArgs e)
        {

        }

        private void Fname1_Click(object sender, EventArgs e)
        {

        }

        private void Image_PICBX_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Recbuttompanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void notify_Click_1(object sender, EventArgs e)
        {
            dynamic result = itexmo(contact.Text, " Warning: Your child " + information.Text + "during the curfew operation", "TR-JERIC125140_Q7FLJ");
            if (result == "0")
            {
                MessageBox.Show("Message has Successfully Sent !");
            }
            else
            {
                MessageBox.Show("Error num " + result + " was encountered");
            }

        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog.Document = PrintDocument;
            PrintPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.print;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString("We would like to address to you that" + " " + information.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(100, 420));
            e.Graphics.DrawString("during the curfew operation and he/she is responsible for any consequences that the", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(80, 440));
            e.Graphics.DrawString("barangay will give to him/her for committing the offense. We already sent a message", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(80, 460));
            e.Graphics.DrawString("to their respective parents knowing that their child has committed a serious violation.", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(80, 480));
            e.Graphics.DrawString("Personal Information", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(80, 520));
            e.Graphics.DrawString("First Name:" + " " + fname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 560));
            e.Graphics.DrawString("Last Name:" + " " + lname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 580));
            e.Graphics.DrawString("Age:" + " " + age.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 600));
            e.Graphics.DrawString("Gender:" + " " + gender.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 620));
            e.Graphics.DrawString("Address:" + " " + address.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 640));
            e.Graphics.DrawString("Parent's Contact #:" + " " + contact.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 660));
            e.Graphics.DrawString("Date:" + " " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 680));
            e.Graphics.DrawString(dashline.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 760));

            e.Graphics.DrawString("HON. MANOLITA M. ABARQUEZ", new Font("Arial Black", 12, FontStyle.Underline), Brushes.Black, new Point(80, 840));
            e.Graphics.DrawString("Barangay Captain", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(140, 870));

            e.Graphics.DrawString("LUCIANA L. ALFEREZ", new Font("Arial Black", 12, FontStyle.Underline), Brushes.Black, new Point(500, 840));
            e.Graphics.DrawString("Curfew Coordinator", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 870));

        }

        private void notify_Click(object sender, EventArgs e)
        {

        }

    }
}
