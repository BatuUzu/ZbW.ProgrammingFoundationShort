namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe3_MatrizenRechner;

partial class MatrizenRechnerForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblA = new Label();
    TxtA00 = new TextBox(); TxtA01 = new TextBox(); TxtA02 = new TextBox();
    TxtA10 = new TextBox(); TxtA11 = new TextBox(); TxtA12 = new TextBox();
    TxtA20 = new TextBox(); TxtA21 = new TextBox(); TxtA22 = new TextBox();
    LblB = new Label();
    TxtB00 = new TextBox(); TxtB01 = new TextBox(); TxtB02 = new TextBox();
    TxtB10 = new TextBox(); TxtB11 = new TextBox(); TxtB12 = new TextBox();
    TxtB20 = new TextBox(); TxtB21 = new TextBox(); TxtB22 = new TextBox();
    CmdAddieren = new Button();
    CmdTransponieren = new Button();
    LblErgebnis = new Label();
    SuspendLayout();

    // LblA
    LblA.AutoSize = true;
    LblA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblA.Location = new Point(12, 12);
    LblA.Name = "LblA";
    LblA.Text = "Matrix A:";

    // TxtA00 .. TxtA22
    TxtA00.Location = new Point(12, 35); TxtA00.Name = "TxtA00"; TxtA00.Size = new Size(45, 23); TxtA00.Text = "0";
    TxtA01.Location = new Point(62, 35); TxtA01.Name = "TxtA01"; TxtA01.Size = new Size(45, 23); TxtA01.Text = "0";
    TxtA02.Location = new Point(112, 35); TxtA02.Name = "TxtA02"; TxtA02.Size = new Size(45, 23); TxtA02.Text = "0";
    TxtA10.Location = new Point(12, 65); TxtA10.Name = "TxtA10"; TxtA10.Size = new Size(45, 23); TxtA10.Text = "0";
    TxtA11.Location = new Point(62, 65); TxtA11.Name = "TxtA11"; TxtA11.Size = new Size(45, 23); TxtA11.Text = "0";
    TxtA12.Location = new Point(112, 65); TxtA12.Name = "TxtA12"; TxtA12.Size = new Size(45, 23); TxtA12.Text = "0";
    TxtA20.Location = new Point(12, 95); TxtA20.Name = "TxtA20"; TxtA20.Size = new Size(45, 23); TxtA20.Text = "0";
    TxtA21.Location = new Point(62, 95); TxtA21.Name = "TxtA21"; TxtA21.Size = new Size(45, 23); TxtA21.Text = "0";
    TxtA22.Location = new Point(112, 95); TxtA22.Name = "TxtA22"; TxtA22.Size = new Size(45, 23); TxtA22.Text = "0";

    // LblB
    LblB.AutoSize = true;
    LblB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblB.Location = new Point(200, 12);
    LblB.Name = "LblB";
    LblB.Text = "Matrix B:";

    // TxtB00 .. TxtB22
    TxtB00.Location = new Point(200, 35); TxtB00.Name = "TxtB00"; TxtB00.Size = new Size(45, 23); TxtB00.Text = "0";
    TxtB01.Location = new Point(250, 35); TxtB01.Name = "TxtB01"; TxtB01.Size = new Size(45, 23); TxtB01.Text = "0";
    TxtB02.Location = new Point(300, 35); TxtB02.Name = "TxtB02"; TxtB02.Size = new Size(45, 23); TxtB02.Text = "0";
    TxtB10.Location = new Point(200, 65); TxtB10.Name = "TxtB10"; TxtB10.Size = new Size(45, 23); TxtB10.Text = "0";
    TxtB11.Location = new Point(250, 65); TxtB11.Name = "TxtB11"; TxtB11.Size = new Size(45, 23); TxtB11.Text = "0";
    TxtB12.Location = new Point(300, 65); TxtB12.Name = "TxtB12"; TxtB12.Size = new Size(45, 23); TxtB12.Text = "0";
    TxtB20.Location = new Point(200, 95); TxtB20.Name = "TxtB20"; TxtB20.Size = new Size(45, 23); TxtB20.Text = "0";
    TxtB21.Location = new Point(250, 95); TxtB21.Name = "TxtB21"; TxtB21.Size = new Size(45, 23); TxtB21.Text = "0";
    TxtB22.Location = new Point(300, 95); TxtB22.Name = "TxtB22"; TxtB22.Size = new Size(45, 23); TxtB22.Text = "0";

    // CmdAddieren
    CmdAddieren.Location = new Point(12, 135);
    CmdAddieren.Name = "CmdAddieren";
    CmdAddieren.Size = new Size(130, 28);
    CmdAddieren.Text = "A + B Addieren";
    CmdAddieren.Click += CmdAddieren_Click;

    // CmdTransponieren
    CmdTransponieren.Location = new Point(155, 135);
    CmdTransponieren.Name = "CmdTransponieren";
    CmdTransponieren.Size = new Size(130, 28);
    CmdTransponieren.Text = "A Transponieren";
    CmdTransponieren.Click += CmdTransponieren_Click;

    // LblErgebnis
    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Courier New", 10F);
    LblErgebnis.Location = new Point(12, 175);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Text = "";

    // MatrizenRechnerForm
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(420, 320);
    Controls.Add(LblA);
    Controls.Add(TxtA00); Controls.Add(TxtA01); Controls.Add(TxtA02);
    Controls.Add(TxtA10); Controls.Add(TxtA11); Controls.Add(TxtA12);
    Controls.Add(TxtA20); Controls.Add(TxtA21); Controls.Add(TxtA22);
    Controls.Add(LblB);
    Controls.Add(TxtB00); Controls.Add(TxtB01); Controls.Add(TxtB02);
    Controls.Add(TxtB10); Controls.Add(TxtB11); Controls.Add(TxtB12);
    Controls.Add(TxtB20); Controls.Add(TxtB21); Controls.Add(TxtB22);
    Controls.Add(CmdAddieren);
    Controls.Add(CmdTransponieren);
    Controls.Add(LblErgebnis);
    Name = "MatrizenRechnerForm";
    Text = "Matrizen-Rechner – Aufgabe 3";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblA;
  private TextBox TxtA00, TxtA01, TxtA02;
  private TextBox TxtA10, TxtA11, TxtA12;
  private TextBox TxtA20, TxtA21, TxtA22;
  private Label LblB;
  private TextBox TxtB00, TxtB01, TxtB02;
  private TextBox TxtB10, TxtB11, TxtB12;
  private TextBox TxtB20, TxtB21, TxtB22;
  private Button CmdAddieren;
  private Button CmdTransponieren;
  private Label LblErgebnis;
}
