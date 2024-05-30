CC = gcc
CFLAGS = -Wall -g
TARGET = syntax_corrector

all: $(TARGET)

$(TARGET): source.o
	$(CC) $(CFLAGS) -o $(TARGET) source.o

source.o: source.c header.h
	$(CC) $(CFLAGS) -c source.c

clean:
	rm -f *.o $(TARGET)
