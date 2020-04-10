# Task 6

## Prerequisites:
Read .NET Book Zero until Chapter 25.

## Description:
### Virus journey. Part3. 
Three new types of Viruses emerged: 
1) VirusAgeist - infects only old people
2) VirusSexist - infects only girls
3) VirusRacist - infects only black guys

There is also a randomly generated park where some people go for a walk. Example:  
![park](https://user-images.githubusercontent.com/5815990/78918993-ef347980-7a99-11ea-947d-2edb8b4eacdc.png)  
You can see 5 types of squares (pixels) in the park. Each has some RGB color:  
<br />
```
   Type (color) - Red, Green, Blue  
1) grass (green) - 0, 255, 0
2) black guy (black) - 0, 0, 0
3) woman (pink) - 224, 33, 138
4) old man (grey) - 178, 190, 181
5) ordinary natural white guy of middle age (beige) - 200, 173, 127
```

The image can be found at path [Task6.PathToParkImage]. Image is written in .PPM format. It's very simple format the description of which you can get [here](http://netpbm.sourceforge.net/doc/ppm.html).
What you really need to know is that each PPM image consists of the following:
1. A "magic number" for identifying the file type. A ppm image's magic number is the two characters "P6".
2. Whitespace (blanks, TABs, CRs, LFs).
3. A width, formatted as ASCII characters in decimal.
4. Whitespace.
5. A height, again in ASCII decimal.
6. Whitespace.
7. The maximum color value (Maxval), again in ASCII decimal. Must be less than 65536 and more than zero.
8. A single whitespace character (usually a newline).
9. A raster of Height rows, in order from top to bottom. Each row consists of Width pixels, in order from left to right. Each pixel is a triplet of red, green, and blue samples, in that order. Each sample is represented in pure binary by either 1 or 2 bytes. If the Maxval is less than 256, it is 1 byte. Otherwise, it is 2 bytes. The most significant byte is first.
A row of an image is horizontal. A column is vertical. The pixels in the image are square and contiguous.  

Example .PPM file from Photoshop:  
```
P6  
800  
600  
255  
00FF00...bytes...  
```
Example .PPM file from Photopea.com  
```
P6  
800 600  
255  
00FF00...bytes...
```
Your task is to read the content of the [Task6.PathToParkImage] file, and on each occurence of the non green pixel invoke an __event__ that should trigger the callbacks of three different viruses. Each virus should react only on specific type of person (color) and should write a log string into output text file if it finds it's victim. Here is the list of output log strings for each virus:

1) VirusAgeist - $"Human at {victim.X}, {victim.Y} was infected by virus ageist"  
2) VirusSexist - $"Human at {victim.X}, {victim.Y} was infected by virus sexist"  
3) VirusRacist - $"Human at {victim.X}, {victim.Y} was infected by virus racist"  

## Goal:
Return a path to file with logs of what was happening in the park.  

## Example input: 
![examplePark](https://user-images.githubusercontent.com/5815990/78990265-b7334200-7b3e-11ea-8bed-bff218719a2e.png)  

## Example output:  
"path/to/logs/file.txt"  
inside file.txt:  
Human at 0, 1 was infected by virus racist  
Human at 1, 1 was infected by virus sexist  
Human at 2, 3 was infected by virus ageist  

## Task clarifications:
This taks is not a nominee to a good example of good events usage, but it's a possibility for you to try to use them.  

## Credits:
https://covid19.com.ua/  
