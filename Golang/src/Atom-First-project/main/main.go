package main

import "fmt"

func main() {

	switch "Hello, World!" {
	case "Hi world":
		fmt.Println("Hi world")
	case "Hello, hi!":
		fmt.Println("Hello, hi!")
	case "Hello, World!":
		fmt.Println("Hellow, World!")
	case "Hello World":
		fmt.Println("Hello world!")
	default:
		fmt.Println("Default")
	}

}
