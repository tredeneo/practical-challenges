defmodule Solution do
    def gets_input do 
        {n,_}=IO.gets("") |>Integer.parse()
        hello(n)
    end
    
    def hello(n) when n ==0, do: nil
    def hello(n) do
        IO.puts("Hello World") 
        hello(n-1)
    end
end

Solution.gets_input()
