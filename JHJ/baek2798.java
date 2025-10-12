import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

// 첫째 줄에 카드의 개수 N(3 ≤ N ≤ 100)과 M(10 ≤ M ≤ 300,000)이 주어진다. 둘째 줄에는 카드에 쓰여 있는 수가 주어지며, 이 값은 100,000을 넘지 않는 양의 정수이다.
// 합이 M을 넘지 않는 카드 3장을 찾을 수 있는 경우만 입력으로 주어진다.
// 첫째 줄에 M을 넘지 않으면서 M에 최대한 가까운 카드 3장의 합을 출력한다.

public class baek2798 {
    public static void main(String[] args) throws Exception { 
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringTokenizer st = new StringTokenizer(br.readLine());

        int N = Integer.parseInt(st.nextToken());
        int M = Integer.parseInt(st.nextToken());

        int[] arr = new int[N];

        st = new StringTokenizer(br.readLine());
        for(int i = 0; i < N; i++){
            arr[i] = Integer.parseInt(st.nextToken());
        }

        int sum = 0;
        for(int i = 0; i < N - 2; i++){
            for(int j = i + 1; j < N - 1; j++){
                for(int k = j + 1; k < N; k++){
                    if(sum < arr[i] + arr[j] + arr[k] && arr[i] + arr[j] + arr[k] <= M){
                        sum = arr[i] + arr[j] + arr[k];
                    }
                }
            }
        }

        System.out.println(sum);
    }
}
