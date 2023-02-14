import sys
import fileinput
from os import getcwd, listdir
from os.path import isfile, join


filename = sys.argv[1]
language = sys.argv[2]
extension = sys.argv[3]

print("Filename:  " + filename)
print("language:  " + language)
print("Extension: " + extension)

file = open(filename, "r")

print("Processing file: " + filename)
outputFilename = filename + ".md"
processedFile = open(outputFilename, 'w')
print("Created file: " + outputFilename)
processedFile.write('```')
processedFile.write(language)
processedFile.write('\n')
for line in file:
    processedFile.write(line)
processedFile.write('```')
#close file
processedFile.close()
print("DONE")
print("")

#input("Press Enter to exit...")
