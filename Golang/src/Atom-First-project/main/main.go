package main

import "fmt"

func largest(x ...int) {
	for _, c := range x {
		fmt.Println(c)

	}
}

func main() {
	largest()

}
