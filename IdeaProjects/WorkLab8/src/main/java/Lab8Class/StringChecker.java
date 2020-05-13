package Lab8Class;

public class StringChecker {

    public int checkString(String outerString, String innerString){
        int index;
        index = outerString.indexOf(innerString);
        return index;
    }
}
