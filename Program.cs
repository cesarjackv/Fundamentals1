// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

for(int i = 1; i < 256; i++){
    Console.WriteLine(i);
}

for(int i = 1; i < 101; i++){
    if(i % 3 == 0 && i % 5 == 0){
        continue;
    }else if(i % 3 == 0 || i % 5 == 0){
    Console.WriteLine(i);
    }
}

for(int i = 1; i < 101; i++){
    string f = "Fizz";
    string b = "Buzz";
    if(i % 3 == 0 && i % 5 == 0){
        Console.WriteLine(f + b);
    }else if(i % 5 == 0){
    Console.WriteLine(b);
    }else if(i % 3 == 0){
    Console.WriteLine(f);
    }
}

int j = 1;
while(j < 256){
    Console.WriteLine(j);
    j++;
}

int k = 1;
while(k < 101){
    if(k % 3 == 0 && k % 5 == 0){
        continue;
    }else if(k % 3 == 0 || k % 5 == 0){
    Console.WriteLine(k);
    }

    k++;
}

int l = 1;
while(l < 101){
    string f = "Fizz";
    string b = "Buzz";
    if(l % 3 == 0 && l % 5 == 0){
        Console.WriteLine(f + b);
    }else if(l % 5 == 0){
    Console.WriteLine(b);
    }else if(l % 3 == 0){
    Console.WriteLine(f);
    }

    l++;
}