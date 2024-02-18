// A class is present that encapsulates the responsibilities of a Word (including that the Word class is responsible
// for storing it's own shown/hidden state). Behavior that is specific to Words is all done by this class,
//  not in other places in the program. And, this class does not include items or behaviors that do not pertain to it.

// All member variables are private.


// you can select any word at random to hide

// When all words in the scripture are hidden, the program should end.
public class Word {
    string text;

    public Word(string text) {
        this.text = text;
    }

    public string GetText() {
        return text;
    }

    public void Hide() {
        text = "";
    }

    public bool IsHidden() {
        return string.IsNullOrEmpty(text);
    }
}