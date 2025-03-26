import sys

def factorial(n):
    return 1 if n == 0 else n * factorial(n - 1)

def fibonacci(n):
    return [0, 1][:n] if n <= 2 else fibonacci(n - 1) + [sum(fibonacci(n - 1)[-2:])]

def sum_list(numbers):
    return sum(numbers)

def average_list(numbers):
    return sum(numbers) / len(numbers) if numbers else 0

def sort_numbers(numbers):
    return sorted(numbers)

def main_menu():
    while True:
        choice = input("\n1.Faktorial 2.Fibonacci 3.Shuma 4.Mesatarja 5.Renditja 6.Dil: ")
        if choice == '1':
            print(f"Faktorial: {factorial(int(input('Numri: ')))}")
        elif choice == '2':
            print(f"Fibonacci: {fibonacci(int(input('Numri: ')))}")
        elif choice == '3':
            print(f"Shuma: {sum_list(list(map(int, input('Numrat: ').split())))}")
        elif choice == '4':
            print(f"Mesatarja: {average_list(list(map(int, input('Numrat: ').split())))}")
        elif choice == '5':
            print(f"Renditur: {sort_numbers(list(map(int, input('Numrat: ').split())))}")
        elif choice == '6':
            sys.exit("Duke dalë...")

if __name__ == "__main__":
    main_menu()
