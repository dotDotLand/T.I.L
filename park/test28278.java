package park;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Stack;

class test2878 {

    

    public static void main(String[] args) throws Exception{

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int count = Integer.parseInt(br.readLine());

        Stack<Integer> stack = new Stack<>();

        while(count-- > 0){

            String input = br.readLine();
            int input1 = Integer.parseInt(input.split(" ")[0]);

            switch(input1){
                case 1:
                    int input2 = Integer.parseInt(input.split(" ")[1]);
                    stack.push(input2);
                    break;
                case 2:
                    if(stack.isEmpty()){
                        sb.append("-1\n");
                    }else{
                        sb.append(stack.pop()).append("\n");
                    }
                    break;
                case 3:
                    sb.append(stack.size()).append("\n");
                    break;
                case 4:
                    if(stack.isEmpty()){
                        sb.append("1\n");
                    }else{
                        sb.append("0\n");
                    }
                    break;
                case 5:
                    if(stack.isEmpty()){
                        sb.append("-1\n");
                    }else{
                        sb.append(stack.peek()).append("\n");
                    }
                    break;
            }
            
        }

        System.out.println(sb);

    }
}