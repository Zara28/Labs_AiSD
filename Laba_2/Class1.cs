using System;

public class BackpackTask
{
	public int[] price;
	public int[] weigth;
	int Weight;
	public BackpackTask(int n, int w)
	{
		Weight = w;
		Random r = new Random();
		price = new int[n];
		weigth = new int[n];
		for (int i = 0; i < n; i++)
		{
				price[i] = r.Next(Weight + 1)+1;
				weigth[i] = r.Next(Weight + 100)+1;
			
		}
	}
	public void Print()
	{
		Console.WriteLine("\nЦены на предметы");
		for (int i = 0; i < price.Length; i++)
		{
			Console.Write(price[i] + " ");
		}
		Console.WriteLine("\nМассы предметов");
		for (int i = 0; i < weigth.Length; i++)
		{
			Console.Write(weigth[i] + " ");
		}
	}
	//Необходимо подобрать такой набор вещей, чтобы он помещался в рюкзаке и имел максимальную ценность (стоимость).
	public void knapsack_din()
	{
		int[] mas = new int[Weight + 1];
		mas[0] = 0;
		for (int w = 1; w <= Weight; w++)
		{
			mas[w] = mas[w - 1];
			for (int i = 0; i < weigth.Length; i++)
			{
				if (weigth[i] <= w)
				{
					mas[w] = Math.Max(mas[w], mas[w - weigth[i]] + price[i]);
				}
			}
		}
		Console.WriteLine("\nМаксимальная цена рюкзака " + mas[Weight]);
	}
	public void knapsack_greedy()
	{
		int[] knapsack = new int [Weight+100];
		for(int i = 0; i<weigth.Length; i++)
		{
			knapsack[weigth[i] / price[i]] = i;
		}
		Array.Sort(knapsack);
		Array.Reverse(knapsack);
		int cost = 0;
		int mass = 0;
		foreach (int i in knapsack)
		{
			if(mass+weigth[knapsack[i]]<= Weight)
			{
				mass += weigth[knapsack[i]];
				cost = cost + price[knapsack[i]];
			}
		}
		int max_c = 1;
		for (int i = 0; i<price.Length; i++)
		{
			max_c = Math.Max(max_c, price[i]);
		}
		if(max_c == 1)
		{
			max_c = 0;
		}
		int result = Math.Max(cost, max_c);
		Console.WriteLine("\nМаксимальная цена рюкзака " + result);
	}

}
