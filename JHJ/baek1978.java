import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.StringTokenizer;

// 주어진 수 N개 중에서 소수가 몇 개인지 찾아서 출력하는 프로그램을 작성하시오.
// 첫 줄에 수의 개수 N이 주어진다. N은 100이하이다. 다음으로 N개의 수가 주어지는데 수는 1,000 이하의 자연수이다.
// 주어진 수들 중 소수의 개수를 출력한다.

public class baek1978 {
    public static void main(String[] args) throws Exception { 
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        
        int N = Integer.parseInt(br.readLine());
        StringTokenizer st = new StringTokenizer(br.readLine());

        boolean[] isPrime = getPrimes(1000);
        int ans = 0;

        while(st.hasMoreTokens()) {
            if(isPrime[Integer.parseInt(st.nextToken())]) ans++;
        }

        System.out.println(ans);
    }

    private static boolean[] getPrimes(int max) {
        boolean[] isPrime = new boolean[1 + max];
        Arrays.fill(isPrime, true);
        isPrime[1] = false;

        for (int i = 2; i * i <= max; i++) {
            if(isPrime[i]) {
                for (int j = i * i; j <= max; j += i) {
                    isPrime[j] = false;
                }
            }
        }

        return isPrime;
    }
}
