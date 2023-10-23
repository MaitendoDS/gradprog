using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

class ViewControl : Control {
    public ViewControl() {
        // stel in dat deze control zichzelf zal hertekenen igv resize
        this.ResizeRedraw = true;

        // stel de achtergrondkleur in op lichtgrijs
        this.BackColor = Color.FromArgb(240, 240, 240);
    }

    // DEZE METHOD WORDT OPGEROEPEN TELKENS DE CONTROL MOET HERTEKEND WORDEN
    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        // merk op dat Console.WriteLine niet werkt in een GUI applicatie (bij gebrek aan console venster)
        System.Diagnostics.Debug.WriteLine("onPaint opgeroepen");

        Graphics gfx = e.Graphics;

        // zorg dat er mooi kan getekend worden (anti-aliasing e.d.)
        gfx.PixelOffsetMode = PixelOffsetMode.Half;
        gfx.SmoothingMode = SmoothingMode.HighQuality;

        // de breedte en hoogte van deze control kun je
        // achterhalen met this.Width en this.Height

        // HIERONDER PLAATS JE JE EIGEN CODE OM TE TEKENEN

        // rode schuine lijn
        Pen redPen = new Pen(Color.Red);
        gfx.DrawLine(redPen, 0, 0, this.Width / 2, this.Height / 2);

        // blauwe schuine lijn
        Pen bluePen = new Pen(Color.Blue);
        gfx.DrawLine(bluePen, this.Width / 2, this.Height / 2, this.Width, this.Height);

        // groen vierkant
        Pen greenPen = new Pen(Color.Green);
        gfx.DrawRectangle(greenPen, 280, 40, 80, 80);

        // gele gevulde rechthoek
        Brush yellowBrush = new SolidBrush(Color.FromArgb(255, 255, 0));
        gfx.FillRectangle(yellowBrush, 240, 90, 100, 20);

        // 5 blauwe cirkels
        for (int i = 0; i < 5; i++) {
            gfx.DrawEllipse(bluePen, i * 50, 100, 50, 50);
        }

        // gevulde ovaal met kleurverloop
        Brush fancyBrush = new LinearGradientBrush(new Rectangle(20, 200, 70, 150), Color.Red, Color.Blue, LinearGradientMode.Vertical);
        gfx.FillEllipse(fancyBrush, 20, 200, 70, 150);
		
		// we moeten de pennen en brushes terug vrijgeven zodat ze geen resources bezet houden
		redPen.Dispose();
		greenPen.Dispose();
		bluePen.Dispose();
		yellowBrush.Dispose();
    }
}
