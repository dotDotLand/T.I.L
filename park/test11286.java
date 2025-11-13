package park;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.PriorityQueue;

public class test11286 {
    public static void main(String[] args) throws Exception {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int N = Integer.parseInt(br.readLine());

        PriorityQueue<Integer> queue = new PriorityQueue<>((o1, o2) -> {
            if(Math.abs(o1) == Math.abs(o2)){
                return o1.compareTo(o2);
            }else{
                return Integer.compare(Math.abs(o1), Math.abs(o2));
            }
        });

        while(N-- > 0){
            int x = Integer.parseInt(br.readLine());

            if(x == 0){
                if(queue.isEmpty()){
                    sb.append(0).append("\n");
                }else{
                    sb.append(queue.poll()).append("\n");
                }
            }else{
                queue.offer(x);
            }
        }

        System.out.println(sb);

    }
}
