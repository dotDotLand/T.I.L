package park;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Stack;

public class test10773 {
    public static void main(String[] args) throws Exception{

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        Stack<Integer> stack = new Stack<>();

        int k = Integer.parseInt(br.readLine());
        while(k-- > 0){
            int n = Integer.parseInt(br.readLine());
            if(n == 0){
                stack.pop();
            }else{
                stack.push(n);
            }
        }

        int sum = stack.stream().mapToInt(Integer::intValue).sum();

        System.out.println(sum);

    }
}
