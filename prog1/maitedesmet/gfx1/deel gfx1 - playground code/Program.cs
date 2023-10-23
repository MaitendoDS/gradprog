using System;
using System.Windows.Forms;

static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        //Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // maak een venster aan
        Form form = new Form();

        // stel de initiele grootte van dit venster in
        form.ClientSize = new System.Drawing.Size(400, 500);

        // stel de titel van het venster in
        form.Text = "Playground";

        // maak een control (= ui onderdeel) en voeg toe aan dit venster
        Control control = new ViewControl();
        form.Controls.Add(control);

        // zorg ervoor dat drawing control ganse venster inneemt
        control.Dock = DockStyle.Fill;

        // Start de grafische user interface en toon de form
        Application.Run(form);
    }
}