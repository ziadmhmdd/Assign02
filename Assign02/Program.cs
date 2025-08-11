namespace Assign02
{
    internal class Program
    {

        #region Q4
        public static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();


            foreach (char c in input)
            {

                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }

                else if (c == ')' || c == '}' || c == ']')
                {

                    if (stack.Count == 0)
                    {
                        return false;
                    }


                    char top = stack.Pop();


                    if (!IsMatchingPair(top, c))
                    {
                        return false;
                    }
                }
            }


            return stack.Count == 0;
        }


        private static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
        #endregion

        #region Q5
        public static T[] RemoveDuplicates<T>(T[] array)
        {
            HashSet<T> seen = new HashSet<T>();
            List<T> result = new List<T>();

            foreach (T item in array)
            {

                if (seen.Add(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
        #endregion

        #region Q6
        public static void RemoveOddNumbers(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
        #endregion

        #region Q7
        //public MixedTypeQueue()
        //{
        //    queue = new Queue<object>();
        //}

       
        //public void Enqueue(object item)
        //{
        //    queue.Enqueue(item);
        //}

       
        //public object Dequeue()
        //{
        //    if (IsEmpty())
        //    {
        //        throw new InvalidOperationException("Queue is empty.");
        //    }
        //    return queue.Dequeue();
        //}

        
        //public object Peek()
        //{
        //    if (IsEmpty())
        //    {
        //        throw new InvalidOperationException("Queue is empty.");
        //    }
        //    return queue.Peek();
        //}

        
        //public bool IsEmpty()
        //{
        //    return queue.Count == 0;
        //}

        //public string GetQueueContents()
        //{
        //    return string.Join(", ", queue.ToArray());
        //}
        #endregion

        #region Q8
        // public static void SearchInStack()
        //{
        //    
        //    Stack<int> stack = new Stack<int>();

        //    
        //    int[] numbers = { 10, 20, 30, 40, 50 }; // Example series
        //    foreach (int num in numbers)
        //    {
        //        stack.Push(num);
        //    }

        //    
        //    Console.WriteLine("Stack Contents (top to bottom): " + string.Join(", ", stack.ToArray()));

        //    // Get target from user
        //    Console.Write("Enter the target integer to search for: ");
        //    if (!int.TryParse(Console.ReadLine(), out int target))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid integer.");
        //        return;
        //    }

        //    
        //    int count = 0;
        //    bool found = false;

        //    while (stack.Count > 0)
        //    {
        //        count++;
        //        int current = stack.Pop();
        //        if (current == target)
        //        {
        //            found = true;
        //            break;
        //        }
        //    }

        //    
        //    if (found)
        //    {
        //        Console.WriteLine($"Target was found successfully and the count = {count}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Target was not found");
        //    }
        // }
        #endregion

        #region Q9
        //  public static int[] FindIntersection(int[] arr1, int[] arr2)
        //{
        //    // Dictionary to store frequency of elements in arr1
        //    Dictionary<int, int> frequency = new Dictionary<int, int>();

        //    // Step 1: Count frequency of each element in arr1
        //    foreach (int num in arr1)
        //    {
        //        if (frequency.ContainsKey(num))
        //        {
        //            frequency[num]++;
        //        }
        //        else
        //        {
        //            frequency[num] = 1;
        //        }
        //    }

        //    // Step 2: Build intersection by checking arr2
        //    List<int> result = new List<int>();
        //    foreach (int num in arr2)
        //    {
        //        // If element exists in frequency dictionary and has positive count
        //        if (frequency.ContainsKey(num) && frequency[num] > 0)
        //        {
        //            result.Add(num);
        //            frequency[num]--; // Decrement frequency
        //        }
        //    }

        //    // Convert result to array and return
        //    return result.ToArray();
        //}

        #endregion

        #region Q10
          public static List<int> FindSubListWithSum(List<int> list, int target)
        {
            int currentSum = 0;
            int start = 0;

            // Iterate through the list using end pointer
            for (int end = 0; end < list.Count; end++)
            {
                // Add current element to sum
                currentSum += list[end];

                // Shrink window while currentSum is greater than target
                while (currentSum > target && start <= end)
                {
                    currentSum -= list[start];
                    start++;
                }

                // Check if currentSum equals target
                if (currentSum == target)
                {
                    // Extract sublist from start to end
                    List<int> result = new List<int>();
                    for (int i = start; i <= end; i++)
                    {
                        result.Add(list[i]);
                    }
                    return result;
                }
            }

            // No sublist found
            return new List<int>();
        }
        #endregion

        #region Q11
        public static Queue<int> ReverseFirstK(Queue<int> queue, int k)
        {
            if (k < 0 || k > queue.Count)
            {
                throw new ArgumentException("K is invalid.");
            }

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            return queue;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1
            //string[] firstLine = Console.ReadLine().Split();
            //int N = int.Parse(firstLine[0]);
            //int Q = int.Parse(firstLine[1]);


            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //for (int i = 0; i < Q; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    int count = 0;

            //    for (int j = 0; j < N; j++)
            //    {
            //        if (arr[j] > X)
            //            count++;
            //    }

            //    Console.WriteLine(count);
            //}
            #endregion

            #region Q2
            //int N = int.Parse(Console.ReadLine());

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //bool isPalindrome = true;

            //for (int i = 0; i < N / 2; i++)
            //{
            //    if (arr[i] != arr[N - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome ? "YES" : "NO");
            #endregion

            #region Q3

            //Queue<int> queue = new Queue<int>();           
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);

            //Console.WriteLine("Befor Reverse:");
            //PrintQueue(queue);

            //ReverseQueue(queue);

            //Console.WriteLine("After Reverse");
            //PrintQueue(queue);
        }

        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        static void PrintQueue(Queue<int> queue)
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            #endregion

            #region Q4
            //string input = "[()]{}}";
            //bool result = IsBalanced(input);
            //Console.WriteLine(result ? "Balanced" : "Not Balanced");

            #endregion

            #region Q5
            //int[] array = { 1, 2, 2, 3, 4, 4, 5, 1 };        
            //Console.WriteLine("Original Array: " + string.Join(", ", array));
            //int[] result = RemoveDuplicates(array);    
            //Console.WriteLine("Array without Duplicates: " + string.Join(", ", result));

            #endregion

            #region Q6

            //      List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };


            //      Console.WriteLine("Original List: " + string.Join(", ", list));


            //      RemoveOddNumbers(list);


            //      Console.WriteLine("List after removing odd numbers: " + string.Join(", ", list));

            #endregion

            #region Q7

            //MixedTypeQueue queue = new MixedTypeQueue();

            //// Insert specified data
            //queue.Enqueue(1);        // int
            //queue.Enqueue("Apple");  // string
            //queue.Enqueue(5.28);     // double

            //// Print queue contents
            //Console.WriteLine("Queue Contents: " + queue.GetQueueContents());

            #endregion

            #region Q8
            //SearchInStack();
            #endregion

            #region Q9
            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 10, 4, 4 };

            //// Print input arrays
            //Console.WriteLine("Array 1: " + string.Join(", ", arr1));
            //Console.WriteLine("Array 2: " + string.Join(", ", arr2));

            //// Find intersection
            //int[] intersection = FindIntersection(arr1, arr2);

            //// Print result
            //Console.WriteLine("Intersection: " + string.Join(", ", intersection));
            #endregion

            #region 10

            //List<int> list = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;

            //// Print input
            //Console.WriteLine("Input List: " + string.Join(", ", list));
            //Console.WriteLine("Target Sum: " + target);

            //// Find sublist
            //List<int> result = FindSubListWithSum(list, target);

            //// Print result
            //if (result.Count > 0)
            //{
            //    Console.WriteLine("Contiguous Sublist: [" + string.Join(", ", result) + "]");
            //}
            //else
            //{
            //    Console.WriteLine("No contiguous sublist found with sum " + target);
            //}

            #endregion

            #region Q11

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //int k = 3;

            //Console.WriteLine("Original Queue: " + string.Join(", ", queue.ToArray()));

            //queue = ReverseFirstK(queue, k);

            //Console.WriteLine("Queue after reversing first " + k + " elements: " + string.Join(", ", queue.ToArray()));

            #endregion

        }
    }
}
