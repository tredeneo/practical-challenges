defmodule Solution do
    def elementos([head|tail]) do
        Enum.each(tail,fn x-> Enum.each(1..head,fn _ -> IO.puts(x) end)end)
        
      
    end

    def main() do
        IO.read(:stdio,:all)
        |> String.split
        |> Enum.map(&String.to_integer(&1))
        |> elementos
      
    end
end

