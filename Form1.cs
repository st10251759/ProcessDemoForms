using System.Diagnostics;

namespace LU1_Process_Demo_Form
{
    public partial class Form1 : Form
    {

        //
        int processId;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This method is executed when  the form loads
            //Retrives and lists all running processes in the listBox1 when the form loads.

            var runningProc = from proc in Process.GetProcesses(".")
                              orderby proc.ProcessName
                              select proc;

            //add each process to the listBox
            foreach (var p in runningProc)
            {
                listBoxDisplay.Items.Add(string.Format("->PID: {0} \t Name:{1} ", p.Id, p.ProcessName));

            }
        }

        private void btnStartChrome_Click(object sender, EventArgs e)
        {
            //Starts Google Chrome with specifed URL and maximizes the window. Stores the process ID of the s
            Process ChromeProc;
            //creatr an instance of the Process class
            try
            {
                //Set-up the process to start 
                ProcessStartInfo startInfo = new ProcessStartInfo("chrome.exe", "varsitycollege.co.za");
                //Start the chrome process
                ChromeProc = Process.Start(startInfo);
                processId = ChromeProc.Id;

            }
            catch (InvalidOperationException ex)
            {
                //Display error message if something goes wrong for the try block 
                MessageBox.Show(ex.Message);
            }

        }

        private void btnKillChrome_Click(object sender, EventArgs e)
        {
            //Termnates all running instances of Google Chrome.
            //Get all the processes with the name 'chrome'
            Process[] chromeProc = Process.GetProcessesByName("chrome");

            try
            {
                //Terminate each chrome process
                foreach (Process p in chromeProc)
                {
                    p.Kill();
                }
            }
            catch (InvalidOperationException ex)
            {
                //Display error message if something goes wrong for the try block
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEndTaskManger_Click(object sender, EventArgs e)
        {
            //Terminate the current instance of the task manager application.
            //get the current process (task manager manager application

        }

        private void btnThreads_Click(object sender, EventArgs e)
        {
            //Display thread information (ID, start time, priority) for the process selected in the listBox1
            

            //Extract the processID from the selected item in the list box
            //Make use of Substring

            //try_catch: get the process by ID

            //Collect thread info for the process >>>ProcessThreadCollection Class
        }
    }
}
