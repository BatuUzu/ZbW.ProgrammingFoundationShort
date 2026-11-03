namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    Console.WriteLine("validartor");
    string passwort;
    bool gueltig = false;

    do
    {
      Console.WriteLine("geben passwort");
      passwort = Console.ReadLine () ?? "";
      bool hatZiffer = false;

      foreach (char zeichen in passwort)
      {
        if (char.IsDigit(zeichen))
        {
          hatZiffer = true;
          break;
        }
      }
      gueltig = passwort.Length >= 8 && hatZiffer;
      if (!gueltig)
      {
        Console.WriteLine("nicht gültig");
        if (passwort.Length < 8)
        {
          Console.WriteLine("passwort zu kurz");
        }
        if (!hatZiffer)
        {
          Console.WriteLine("keine zahl");
        }
      }
    } while (!gueltig);

    Console.WriteLine("okay paswort");
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);

    // TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")

    // TODO 3: bool hatZiffer = false;
    //         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen

    // TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben

    // TODO 5: Nach der Schleife Erfolgsmeldung ausgeben
  }
}
