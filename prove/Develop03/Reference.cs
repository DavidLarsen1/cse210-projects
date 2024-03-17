 // A class is present that encapsulates the responsibilities of a Reference (including handling multiple verses).
 //  Behavior that is specific to References is all done by this class, not in other places in the program.
 //  And, this class does not include items or behaviors that do not pertain to it.

 // All member variables are private.

 // Proverbs 3:5-6
 // John 3:16


public class ScriptureReference {
    string reference;

    public ScriptureReference(string reference) {
        this.reference = reference;
    }

    public string GetReference() {
        return reference;
    }
}
