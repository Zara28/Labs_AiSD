#include <time.h>  
#include <iostream>
#include "Deque.h"
using namespace std;
int my_bubble_sort(int mas[], int n);
void my_q_sort(int mas[], int n);

int main()
{
    setlocale(LC_CTYPE, "rus");
    int mas[10000];
    int mas_s[10000];
    int n = 0;
    int task = 0;
    while (task != -1)
    {
        cout << "Введите номер задания ";
        cin >> task;
        switch (task)
        {
        case 1:
            do
            {
                cout << "Введите размер массива ";
                cin >> n;
                if (n != -1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        mas[i] = rand() % 100 + 1;
                    }
                    int time = clock();
                    my_q_sort(mas, n);
                    time = clock() - time;
                    cout << "Сортровка пузырьком массива на  " << n << " элементов происходит за " << my_bubble_sort(mas, n) << "\n";
                }

            } while (n != -1);
            break;
        case 2:
            do
            {
                cout << "Введите размер массива ";
                cin >> n;
                if (n != -1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        mas[i] = rand() % 100 + 1;
                    }
                    int time = clock();
                    my_q_sort(mas, n);
                    time = clock() - time;
                    cout << "Быстрая сортировка массива на " << n << " элементов происходит за " << time << "\n";
                }

            } while (n != -1);
            break;
        case 3:
            Deque dec = {};
            cout << "Пустая ли очередь " << dec.Empty() << "\n";
            int elem;
            cout << "Добавим элементов в очередь";
            dec.Push_front(10);
            dec.Push_back(18);
            dec.Print();
            cout << "\n" << "Вставим в начало очереди 15 и в конец очереди 11" << "\n";
            dec.Push_back(11);
            dec.Push_front(15);
            dec.Print();
            cout << "\n" << "Выведем первый и последний элемент в очереди ";
            cout << dec.front() << " " << dec.back();
            cout << "\nРазмер oчереди " << dec.Size() << "\n";
            cout << "Введите индекс элемента, который хотите вывести ";
            int ind;
            cin >> ind;
            if (ind < dec.Size())
            {
                cout << dec.At(ind);
            }
            else cout << "Индекс вне границ";
            cout << "\nВведите значение элемента, наличие которого хотите проверить ";
            int d;
            cin >> d;
            cout << dec.Has(d);
        }
    }
  
    
}

int my_bubble_sort(int mas [], int n)
{
    int time = clock();
    bool sort;
    for (int i = 0; i < n; i++)
    {
        sort = true;
        for (int j = i; j < n; j++)
        {
            if (mas[i] > mas[j])
            {
                int t = mas[i];
                mas[i] = mas[j];
                mas[j] = t;
                sort = false;
            }

        }
        if (sort)
        {
            break;
        }
    }
    return clock() / 1000.0;
}

void my_q_sort(int mas[], int n) {
    int begin = 0;
    int end = n - 1;

    int center = mas[n / 2];

    do {
        while (mas[begin] < center) {
            begin++;
        }
        while (mas[end] > center) {
            end--;
        }

        if (begin <= end) {
            int tmp = mas[begin];
            mas[begin] = mas[end];
            mas[end] = tmp;

            begin++;
            end--;
        }
    } while (begin <= end);


    if (end > 0) {
        my_q_sort(mas, end + 1);
    }
    if (begin < n) {
        my_q_sort(&mas[begin], n - begin);
    }
}