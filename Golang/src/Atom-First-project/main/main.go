package main

/*
Use https://godoc.org/sort to sort the following

(1)
type people []string
studyGroup := people{"Zeno", "John", "Al", "Jenny"}

(2)
s := []string{"Zeno", "John", "Al", "Jenny"}

(3)
n := []int{7, 4, 8, 2, 9, 19, 12, 32, 3}

Also sort the above in reverse order
*/

import (
	"fmt"
	"sort"
)

func main() {
	type people []string
	studyGroup := people{"Zeno", "John", "Al", "Jenny"}
	sort.Strings(studyGroup)
	fmt.Println(studyGroup)
	sort.Sort(sort.Reverse(sort.StringSlice(studyGroup)))
	fmt.Println(studyGroup)
	s := []string{"Zeno", "John", "Al", "Jenny"}
	sort.Strings(s)
	fmt.Println(s)
	sort.Sort(sort.Reverse(sort.StringSlice(s)))
	fmt.Println(s)
	n := []int{7, 4, 8, 2, 9, 19, 12, 32, 3}
	sort.Ints(n)
	fmt.Println(n)
	sort.Sort(sort.Reverse(sort.IntSlice(n)))
	fmt.Println(n)
}
