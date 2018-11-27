using System;

namespace Frick_and_Frack
{
    // Quando si potrebbe fare meglio ma per motivi di tempo
    // o di convenienza non si fa refactoring. Il termine "accussì accussì" significa
    // "così così" in napoletano. Normalmente è la risposta standard quando si incontra
    // un conoscente. Infatti rispondere "bene, grazie" ci esporrebbe ai cattivi occhi o
    // al refactoring delle persone invidiose.
    public class AccussìAccussì : Attribute
    {
        private string property;
        public AccussìAccussì(string property) => this.property = property;
    }

    // Quando si potrebbe fare meglio, ma un po' più grave. "Nà mezza chiavica" significa
    // letteralmente "una mezza cloaca massima". E per chi lo trovasse volgare, basta
    // pensare all'alternativa dello scendere in campo.
    public class NaMezaChiavica : Attribute
    {
        private string property;
        public NaMezaChiavica(string property) => this.property = property;
    }

    // "Magg cecat" significa letteralmente "son diventato cieco". L'attributo va' usato quando si è di fretta e comunque quando non frega niente a nessuno. 
    // Il solipsismo nello scrivere il codice porta a due risultati distinti, l'autoreferenzialità e l'isolamento.
    // Entrambi recano ad una morte triste o in pizzeria il sabato sera.
    public class MaggCecat : Attribute
    {
        private string property;
        public MaggCecat(string property) => this.property = property;
    }

    // Significato "Tutto bene, fratello?". Da usare quando non ti spetta ma lo scrivi comunque mosso
    // da altruismo e voglia di fare. Quando poi non funziona è semplice dichiarare il fratello
    // come singleton.
    public class TuttBenOFrà : Attribute
    {
        private string property;
        public TuttBenOFrà(string property) => this.property = property;
    }

    // Significato "Dammi il cinque". Da usare come sopra. Non indicato se non siete giovani o
    // avete perso le dita lanciando la bomba di Maradona l'ultimo dell'anno.
    public class SciòCinque : Attribute
    {
        private string property;
        public SciòCinque(string property) => this.property = property;
    }

    // Da usare quando il fix non andrà mai in produzione a causa di continui rinvii.
    // Letteralmente significa "tieni in mano" o "tieni in caldo".
    public class TienInMan : Attribute
    {
        private string property;
        public TienInMan(string property) => this.property = property;
    }

    // Quando non sei d'accordo con il tuo team. Il termine vagamente ingiurioso significa
    // "che tu possa versare il sangue". Da evitare assolutamente se si scrive il codice mentre
    // si ha un dito nel naso.
    public class PozzIttòSang : Attribute
    {
        private string property;
        public PozzIttòSang(string property) => this.property = property;
    }

    // Quando hai lavorato per ore e ore e forse funziona tutto
    // ma non ne sei sicuro. Fa riferimento alle commedie di Eduardo. "Deve passare la nottata" è
    // un termine tra la speranza e la rassegnazione. O il dramma di una guardia notturna albina.
    public class AddàPassàaNuttata : Attribute
    {
        private string property;
        public AddàPassàaNuttata(string property) => this.property = property;
    }

    // Quando hai troppa confidenza in quello che scrivi e i colleghi invidiosi ti bucano le
    // ruote della bicicletta e casa tua dista 20 km.
    public class MaAvetaFàSolNaPompa : Attribute
    {
        private string property;
        public MaAvetaFàSolNaPompa(string property) => this.property = property;
    }

    // Quando vuoi scusarti con gli utenti finali ma senza dare nell'occhio.
    // "Mi dovete solo scusare". Il DOVETE normalmente viene sottolineato
    // da un tirapugni o per i nostalgici da un real moschetto borbonico.
    public class MaveteScusà : Attribute
    {
        private string property;
        public MaveteScusà(string property) => this.property = property;
    }


    // Come prima. Quando vuoi scusarti con gli utenti finali. Significato "Io stavo solo scherzando".
    public class IStevPazziand : Attribute
    {
        private string property;
        public IStevPazziand(string property) => this.property = property;
    }

    // Quando non hai idea su cosa faccia il metodo o la classe e ti ricordi
    // vagamente di aver studiato a scuola l'impero ottomano. Vien voglia
    // di stampare il codice e farne un'odalisca in origami.
    public class Chemustafà : Attribute
    {
        private string property;
        public Chemustafà(string property) => this.property = property;
    }

    // Quando il codice puzza. Abbastanza autoesplicativo. Quando venne chiesto a Galileo
    // di abiurare l'uso delle interfacce sotto pena della morte, egli rispose: "Eppur fieta!"
    public class EppurFeta : Attribute
    {
        private string property;
        public EppurFeta(string property) => this.property = property;
    }

    // Come dice l'andante "Acqua cheta, fa pantano e feta", da usare quando il codice puzza.
    public class AcquaCheta : Attribute
    {
        private string property;
        public AcquaCheta(string property) => this.property = property;
    }

    // In caso di antipattern, può essere utilizzato con significato :"E'arrivato!" come
    // per dire: ti pare che se non l'avessimo valutato prima noi, non l'avremmo utilizzato?
    // Poi perdete un'ora a spiegare il significato di una domanda retorica e due ore il condizionale.
    public class EAsciut : Attribute
    {
        private string property;
        public EAsciut(string property) => this.property = property;
    }

    // "Sembri il fratello del pazzo". Autoesplicativo. Si narra che Masaniello fosse stato
    // indotto alla pazzia da una droga somministrata da un amico invidioso che amava il cobol.  
    public class ParOFratRoPazz : Attribute
    {
        private string property;
        public ParOFratRoPazz(string property) => this.property = property;
    }

    // Codice intoccabile, l'ha scritto il capo! "Attacca il ciuccio dove vuole il padrone."
    public class AttacOCiucc : Attribute
    {
        private string property;
        public AttacOCiucc(string property) => this.property = property;
    }


    // Da usare in presenza di codice che supera il concetto classico di causalità.
    // Ogni modifica al codice produrrebbe uno tsunami in bombonesia.
    // Con buona pace di chi non creda che esista la bombonesia
    // e che gli abitanti siano attori pagati dagli Stati Uniti.
    // Per i più curiosi la frase completa è "Nun sputà ‘ncielo ca ‘nfaccia te torna…",
    // non sputare in cielo che in faccia ti ritorna,
    public class SputInCiel : Attribute
    {
        private string property;
        public SputInCiel(string property) => this.property = property;
    }


}
