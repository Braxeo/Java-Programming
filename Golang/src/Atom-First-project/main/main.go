package main

import "fmt"

type Square struct {
	WLength float64
	HLength float64
}

type Triangle struct {
	BLength float64
	HLength float64
}

func (s Square) area() float64 {
	return s.HLength * s.WLength
}

func (s Triangle) area() float64 {
	return 0.5 * s.BLength * s.HLength
}

type Shape interface {
	area() float64
}

func main() {
	sq := Square{10, 50}
	x := sq.area()
	fmt.Println(x)
}
