package main

import "fmt"

func main() {
	greeting := map[int]string{
		0: "Hello",
		1: "Goodbye",
		2: "Dis 2, who dis?",
	}

	fmt.Println(greeting)

	if val, exists := greeting[2]; exists {
		delete(greeting, 2)
		fmt.Println("Val: ", val)
		fmt.Println("exists: ", exists)
		fmt.Println(greeting)

	} else {
		fmt.Println("That value doesn't exist.")
		fmt.Println("val: ", val)
		fmt.Println("exists: ", exists)
		fmt.Println(greeting)

	}

}
