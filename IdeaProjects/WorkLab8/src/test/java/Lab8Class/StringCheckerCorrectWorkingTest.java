package Lab8Class;

import org.junit.jupiter.api.Test;
import java.util.Random;
import static org.junit.jupiter.api.Assertions.*;

class StringCheckerCorrectWorkingTest {

    private String generateString(int length){
        String resultString;
        Random random = new Random();
        char [] charsOfString = new char[length];
        for (int i = 0; i < length; i++) {
            charsOfString[i] = (char) (random.nextInt(127) + 1);
        }
        resultString = new String(charsOfString);
        return  resultString;
    }

    @Test
    void checkStringNonExisting() {
        StringChecker stringChecker = new StringChecker();
        int result = -1;
        String outerString = "AAA";
        String innerString = "BBB";
        assertEquals(result, stringChecker.checkString(outerString, innerString));
    }

    @Test
    void checkStringExisting() {
        StringChecker stringChecker = new StringChecker();
        int result = 2;
        String outerString = "Hello world";
        String innerString = "llo w";
        assertEquals(result, stringChecker.checkString(outerString, innerString));
    }

    @Test
    void checkStringStressSize() {
        Random random = new Random();
        StringChecker stringChecker = new StringChecker();
        int innerStringSize = random.nextInt(300) + 100;
        int outerStringSize = random.nextInt(5000) + 1000;

        String outerString = generateString(outerStringSize);
        String innerString = generateString(innerStringSize);

        int expectedResult = outerString.indexOf(innerString);
        assertEquals(expectedResult, stringChecker.checkString(outerString, innerString));
    }

    @Test
    void checkStringStressNumber(){
        Random random = new Random();
        StringChecker stringChecker = new StringChecker();
        for(int i = 0; i < 10000; i ++){
            int innerStringSize = random.nextInt(10);
            int outerStringSize = random.nextInt(100);
            String outerString = generateString(outerStringSize);
            String innerString = generateString(innerStringSize);
            int expectedResult = outerString.indexOf(innerString);
            assertEquals(expectedResult, stringChecker.checkString(outerString, innerString));
        }
    }
}