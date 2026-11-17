namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag1_Einkaufsliste;

// ============================================================
// AUFTRAG 1 – Einkaufsliste (⭐ Einfach | ~15 Min.)
//
// Verwaltet eine Einkaufsliste mit List<string>.
//
// Anforderungen:
//   - TxtArtikel: Artikel eingeben
//   - CmdHinzufuegen: Zur Liste hinzufügen
//   - CmdEntfernen: Ausgewählten Artikel entfernen
//   - CmdAlleLoeschen: Alle löschen
//   - LblAnzahl: Anzahl anzeigen
// ============================================================

public partial class EinkaufslisteForm : Form
{
  private readonly List<string> _artikel = [];
  // TODO 1: private List<string> _artikel = new();

  public EinkaufslisteForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    if (string.IsNullOrEmpty(artikel))
    {
      MessageBox.Show("Keine Artikel bitte eingeben");
        return;
    }

    _artikel.Add(TxtArtikel.Text.Trim());
    AktualisiereListBox();
    TxtArtikel.Clear();
    TxtArtikel.Focus();
    // TODO 2: Leere Eingabe prüfen
    // TODO 3: _artikel.Add(TxtArtikel.Text.Trim())
    // TODO 4: ListBox aktualisieren, LblAnzahl setzen
    // TODO 5: TxtArtikel leeren und fokussieren
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    if (LstArtikel.SelectedIndex < 0)
    {
      MessageBox.Show("Kein Index ausgewählt");
      return;
    }

    _artikel.RemoveAt(LstArtikel.SelectedIndex);
    AktualisiereListBox();
    // TODO 6: SelectedIndex prüfen (>= 0)
    // TODO 7: _artikel.RemoveAt(LstArtikel.SelectedIndex)  – Index statt Text (Duplikate!)
    // TODO 8: ListBox aktualisieren
  }

  private void CmdAlleLoeschen_Click(object sender, EventArgs e)
  {
    _artikel.Clear();
    AktualisiereListBox();
    // TODO 9: _artikel.Clear(), ListBox leeren, LblAnzahl = "0"
  }

  private void AktualisiereListBox()
  {
    LstArtikel.Items.Clear();

    foreach (string a in _artikel)
    {
      LstArtikel.Items.Add(a);
    }

    LblAnzahl.Text=$"Artikel: {_artikel.Count}";
    // TODO 10: LstArtikel.Items.Clear();
    //          foreach (string a in _artikel) LstArtikel.Items.Add(a);
    //          LblAnzahl.Text = $"Artikel: {_artikel.Count}";
  }
}
