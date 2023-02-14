import fileinput
from os import getcwd, listdir
from os.path import isfile, join
import re

# file parameters when search directory
extension = ".cs"

# get current working directory
workingDir = getcwd()
print("Working directory: " + workingDir)

# get all files in this directory
allFiles = [f for f in listdir(workingDir) if isfile(join(workingDir, f))]

# iterate over all files in collection
for file in allFiles:
    # check to see if file is markdown file
    if file.endswith(extension):
        print("Processing file: " + file)
        processedFileName = file.replace(extension, ".md")
        processedFile = open(processedFileName, 'w')
        print("Created file: " + processedFileName)
        processedFile.write('```csharp\n')
        # for line in fileinput.input(file):
        # processedFile.write(line)
        processedFile.write(fileinput.input(file))
        processedFile.write('```')
        #close file
        processedFile.close()
        print("")

input("Press Enter to exit...")
