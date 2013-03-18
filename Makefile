all:
	make -C "./Increment"
	cp "./Increment/libIncrement.a" "./BindingIncrement/BindingIncrement/libIncrement.a"

clean:
	rm -f "./BindingIncrement/BindingIncrement/*.a"