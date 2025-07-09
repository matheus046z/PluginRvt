using Autodesk.Revit.UI;
using System.Windows;

namespace PluginRvt
{
    public partial class MainWindow : Window
    {
        private ExternalCommandData _commandData;

        public MainWindow(ExternalCommandData commandData)
        {
            InitializeComponent();
            _commandData = commandData;
            // Aqui você pode popular os ComboBox com os vínculos
        }

        private void Furar_Click(object sender, RoutedEventArgs e)
        {
            // Aqui você executa a lógica de detecção e inserção de furos
            this.Close();
        }
    }
}