using System;
public class Buchstabendreher {

    // Dreht einzelne Wörter des Satzes um, aber behält Wort-Reihenfolge bei
    // Teilt übergebenen Satz in dessen Wörter auf und übergibt diese an die reverse() Methode
    public string reverseLetters(string sentence) {
        string[] sentenceArray = sentence.Split(" ");
        string[] reversedArray = new string[sentenceArray.Length];
        for(int i = 0; i < sentenceArray.Length; i++) {
            reversedArray[i] = reverse(sentenceArray[i]);
        }
        string reversedString = string.Join(" ", reversedArray);
        
        return reversedString;
    }

    // Wandelt übergebenes Wort in Char-Array, dreht diesen um, und fügt ihn wieder zu einem String (einzelnes Wort) zusammen
    public string reverse(string word) {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversedWord = string.Join("", charArray);

        return reversedWord;
    }

    // Dreht kompletten übergebenen Satz um, verändert aber nicht dessen Wörter
    public string reverseWords(string sentence) {
        string[] sentenceArray = sentence.Split(" ");
        Array.Reverse(sentenceArray);
        string reversedString = string.Join(" ", sentenceArray);
        
        return reversedString;
    }

    // Dreht sowohl den Satz selbst um, als auch dessen Wörter 
    // Hierzu werden, wie gefordert, die beiden anderen Methoden verwendet
    // Zuerst werden mittels der reverseLetters() Methode die Buchstaben der Wörter vertauscht, und anschließend mittels der reverseWords() Methode die Satzstellung umgedreht
    public  string reverseSentence(string sentence) {
        string reversedLettersSentence = this.reverseLetters(sentence);
        string reversedAllSentence = this.reverseWords(reversedLettersSentence); 

        return reversedAllSentence;
    }
    
    // Main Methode (führt Programm aus)
    public static void Main(string[] args) {
        Buchstabendreher buchstabendreher = new Buchstabendreher();     // Instantiierung der Klasse Buchstabendreher
        Console.WriteLine("Zu verändernden Satz eingeben: ");
        string sentence = Console.ReadLine();
        Console.WriteLine(buchstabendreher.reverseLetters(sentence));
        Console.WriteLine(buchstabendreher.reverseWords(sentence));
        Console.WriteLine(buchstabendreher.reverseSentence(sentence));
    }
}