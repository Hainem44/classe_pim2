using System.Windows.Forms;

namespace classe_pim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CRUDbabapet cRUDbabapet = new CRUDbabapet();
            CRUDbabapet mainForm = cRUDbabapet;
            Application.Run(mainForm);

        }
    }
}
