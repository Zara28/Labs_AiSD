#pragma once
#include <time.h>  
#include <iostream>
using namespace std;
struct Node
{
    int data;
    Node* next;
};

class Deque
{
private:
    Node* head; 
public:
    Deque() 
    {
        head = NULL;
    }
    void Push_back(int d)
    {
        Node* nd = new Node; 
        nd->data = d;        
        nd->next = NULL;     
        if (head == NULL)     
            head = nd;
        else                
        {
            Node* current = head;
            while (current->next != NULL)
                current = current->next;
            current->next = nd;
        }
    }
    void Push_front(int d)
    {
        Node* nd = new Node;
        nd->data = d;
        nd->next = NULL;
        if (head == NULL)     
            head = nd;
        else
        {
            nd->next = head;
            head = nd;
        }
    }
    int front()
    {
        return head->data;
    }
    int back()
    {
        Node* current = head;
        while (current->next != NULL)
            current = current->next;
        return current->data;
    }
    int At(int index)
    {
        int i = 0;
        Node* current = head;
        while (i != index && current->next != NULL)
        {
            current = current->next;
            i++;
        }
        return current->data;
    }
    int Size()
    {
        int i = 1;
        Node* current = head;
        while (current->next != NULL)
        {
            i++;
            current = current->next;
        }
        return i;
    }
    void Print()
    {
        Node* current = head;
        while (current != NULL)
        {
            cout << current->data << "->";
            current = current->next;
        }
        cout << "NULL";
    }
    bool Empty()
    {
        if (head == NULL)
        {
            return true;
        }
        return false;
    }
    bool Has(int d)
    {
        Node* current = head;
        while (current != NULL)
        {
            if (current->data == d)
            {
                return true;
            }
            else current = current->next;
        }

        return false;
    }
};
