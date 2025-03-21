import mysql.connector

con = mysql.connector.connect(
    host="localhost",
    user="root",
    password=" ",
    database="parfumet"
)

if con.is_connected():
    print("Lidhja me SQL u krye")

con.close()


def factorial(n):
    if n == 0 or n == 1:
        return 1
    return n * factorial(n - 1)


def fibonacci(n, sequence=None):
    if sequence is None:
        sequence = [0, 1]
    if len(sequence) >= n:
        return sequence[:n]
    sequence.append(sequence[-1] + sequence[-2])
    return fibonacci(n, sequence)


def sum_list(numbers):
    return sum(numbers)


def average_list(numbers):
    return sum_list(numbers) / len(numbers) if numbers else 0


def sort_numbers(numbers):
    return sorted(numbers)


def validate_input(prompt, type_func=int):
    while True:
        try:
            value = type_func(input(prompt))
            if isinstance(value, (int, float)) and value < 0:
                raise ValueError("Numri duhet të jetë pozitiv")
            return value
        except ValueError as e:
            print(f"Gabim: {e}, provo përsëri.")


def get_list():
    try:
        numbers = list(map(int, input("Jep një listë numrash të ndarë me hapësirë: ").split()))
        return numbers
    except ValueError:
        print("Gabim! Jep vetëm numra të ndarë me hapësirë.")
        return get_list()


def main_menu():
    print("\n--- Math Helper ---")
    print("1. Llogarit faktorialin")
    print("2. Gjenero serinë Fibonacci")
    print("3. Llogarit shumën e një liste")
    print("4. Llogarit mesataren e një liste")
    print("5. Rendit listën e numrave")
    print("6. Dalje")

    choice = validate_input("Zgjidh një opsion: ")

    if choice == 1:
        num = validate_input("Jep një numër për faktorialin: ")
        print(f"Faktoriali i {num} është {factorial(num)}")
    elif choice == 2:
        num = validate_input("Jep numrin e termave për Fibonacci: ")
        print(f"Seria Fibonacci: {fibonacci(num)}")
    elif choice == 3:
        numbers = get_list()
        print(f"Shuma e listës është: {sum_list(numbers)}")
    elif choice == 4:
        numbers = get_list()
        print(f"Mesatarja e listës është: {average_list(numbers)}")
    elif choice == 5:
        numbers = get_list()
        print(f"Lista e renditur: {sort_numbers(numbers)}")
    elif choice == 6:
        print("Dalje nga programi...")
        return
    else:
        print("Opsion i pavlefshëm, provo përsëri.")

    main_menu()


if __name__ == "__main__":
    main_menu()
