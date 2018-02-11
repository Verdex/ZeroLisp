
cc = csc
reader = Reader/*.cs
evaluator = Evaluator/*.cs
data = Data/*.cs

all : 
	$(cc) Program.cs $(reader) $(evaluator) $(data)

clean :
	rm -rf *.exe
