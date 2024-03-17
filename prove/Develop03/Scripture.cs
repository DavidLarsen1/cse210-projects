// A class is present that encapsulates the responsibilities of a Scripture. Behavior that is specific to Scriptures is
//  all done by this class, not in other places in the program. And, this class does not include items or behaviors
//  that do not pertain to it.

// All member variables are private.


// "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."

public class Scripture {
    Word[] words;
    ScriptureReference reference;

    public Scripture(string reference, string text) {
        this.reference = new ScriptureReference(reference);
        string[] wordArray = text.Split(' ');
        words = new Word[wordArray.Length];
        for (int i = 0; i < wordArray.Length; i++) {
            words[i] = new Word(wordArray[i]);
        }
    }

    public void Display() {
        Console.WriteLine(reference.GetReference());
        foreach (Word word in words) {
            Console.Write(word.IsHidden() ? "______ " : word.GetText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords() {
        Random random = new Random();
        for (int i = 0; i < 3; i++) {
            int index = random.Next(0, words.Length);
            words[index].Hide();
        }
    }


    public bool AllWordsHidden() {
        foreach (Word word in words) {
            if (!word.IsHidden()) {
                return false;
            }
        }
        return true;
    }
}