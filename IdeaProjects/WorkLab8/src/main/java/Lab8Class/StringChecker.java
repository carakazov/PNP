package Lab8Class;
import java.util.Random;

public class StringChecker {

    public int checkString(String outerString, String innerString){
        int index;
        index = outerString.indexOf(innerString);
        return index;
    }

    public String generateOuterString(){
        String resultString;
        Random random = new Random();
        int length = random.nextInt(75) + 45;
        char [] charsOfString = new char[length];
        for (int i = 0; i < length; i++) {
            charsOfString[i] = (char) (random.nextInt(127) + 1);
        }
        resultString = new String(charsOfString);
        return  resultString;
    }

    public String generateInnerString(){
        String resultString;
        Random random = new Random();
        int length = random.nextInt(35) + 10;
        char [] charsOfString = new char[length];
        for (int i = 0; i < length; i++) {
            charsOfString[i] = (char) (random.nextInt(127) + 1);
        }
        resultString = new String(charsOfString);
        return  resultString;
    }
}
