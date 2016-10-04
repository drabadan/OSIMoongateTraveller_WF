using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrabadanCoreLib.Core;
using DrabadanCoreLib.OSISubScripts;
using DrabadanCoreLib.Core.ScriptActions;

namespace OSIMoongateTravellerForm
{
    public partial class OSIMoongateTravellerForm : Form
    {
        public OSIMoongateTravellerForm()
        {
            InitializeComponent();

            ScriptActionExecuter.Messanger = SendConsoleMessage;

            MoongateTraveller.Moongates.ToList().ForEach(m => {
                comboBox1.Items.Add($"City: {m.Title}, World: {m.World}");
            });

            comboBox1.SelectedItem = comboBox1.Items?[0];
        }

        private void SendConsoleMessage(string message)
        {
            this?.Invoke((MethodInvoker)delegate
            {
                Console_richTextBox.SelectionStart = 0;
                Console_richTextBox.SelectionLength = 0;
                Console_richTextBox.SelectedText = DateTime.Now + ": " + message + Environment.NewLine;
            });
        }
        //just random comment
        private async void button1_Click(object sender, EventArgs e)
        {
            await TravelToMoongateTest();
        }

        private static Moongate CurrentMoongate = null;
        private async Task TravelToMoongateTest()
        {
            await GetMoongateTest();
            var moongate = await MoongateTraveller.FindNearestMoongate();

            var gate = MoongateTraveller.Moongates.FirstOrDefault(m => comboBox1.SelectedItem.ToString().Contains(m.Title) && comboBox1.SelectedItem.ToString().Contains(m.World.ToString()));
            if (gate == null)
            {
                SendConsoleMessage("Not found gate in sequence!");
                return;
            }

            if (gate == CurrentMoongate)
            {
                SendConsoleMessage("I am already at a place!");
                return;
            }

            var dist = await SelfActions.GetDistanceToLocationAsync(moongate.Location);
            if (dist > 1)
                await SelfActions.ApproachToLocationAsync(moongate.Location);

            uint gateId = await FindTypeActions.FindAtLocationAsync(moongate.Location, 0x0F6C);
            if(gateId == 0x0)
            {
                SendConsoleMessage("Moongate not found!");
                return;
            }
            var result = await UseObjectHandler.UseOSIMoongate(gateId);
            
            await UseObjectHandler.TravelToMoongateAsync(result, gate);
            await GetMoongateTest();
        }
        
        private async Task GetMoongateTest()
        {
            var moongate = await MoongateTraveller.FindNearestMoongate();
            if (moongate != null)
            {
                CurrentMoongate = moongate;
                SendConsoleMessage($"Currently i am at: {moongate.Title}, {moongate.World.ToString()}");
            }
        }               
        
        private async void button2_Click(object sender, EventArgs e)
        {
            await GetMoongateTest();
        }
        
    }
}
