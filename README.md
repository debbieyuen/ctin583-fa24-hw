# CTIN 583 (Fall 2024) Programming Homework Assignments

Please refer to this GitHub repository for some of your homework. Feel free to book mark or star this repository to make things easier! 

## Homeworks
| Homework  | Description | Language | Link
| --------- | ------------- | ---- | ---- |
| [HW 02](https://ctin583.usc.edu/latest/Homework/hw02/) | Classes and Coroutines | C# | [Folder](./hw02) |
| [HW 03](https://ctin583.usc.edu/latest/Homework/hw03/) | Gyroscope | C# | [Folder](./hw03) |
| [HW 04](https://ctin583.usc.edu/latest/Homework/hw04/) | Generics and Inheritance | C# | [Folder](./hw04) |
| [HW 05](https://ctin583.usc.edu/latest/Homework/hw05/) | Enumerations | C# | [Folder](./hw05) |
| HW 06 | Euler Angles, Matrix, Quaternions | C# | Not Released|
| HW 07 | Dot and Cross Product | C# | Not Released |
| HW 11 | Shaders | HLSL | Not Released |
| HW 14 | Delegates and Events | C# | Not Released |
| HW 15 | Polymorphism | C# | Not Released |

## Set Up

Fork this (Debbie's) repository by going up to the header and finding `fork`. 
<img width="555" alt="Screenshot 2024-08-31 at 5 06 42 PM" src="https://github.com/user-attachments/assets/12501f27-bf9e-4c5a-bbf9-b46eee85a27b">

Then copy over the main branch only before hitting **Create Fork**.
<img width="1280" alt="Screenshot 2024-08-31 at 5 04 50 PM" src="https://github.com/user-attachments/assets/e18f0157-9778-46f2-9b42-2fa6a7bb8bc1">

Clone **your** new repository via Terminal or GitHub Desktop. Instead of my repository, remember to clone the new repository you created. 
Remember to add Debbie (@debbieyuen) and Jerry (jerryxu1999) to your repository under settings!!
If you are cloning with Terminal, use `cd [folder name]` to clone it to the location of your choice.
```bash
$ git clone https://github.com/debbieyuen/ctin583-fa24-hw
```
If this is not hw02, remember to fetch for the new assignments before starting each homework assignment!
```bash
$ git checkout origin main
$ git status
$ git pull origin main
$ git fetch upstream
```
Create a new branch with your name. For me, I will name mine `debbie`. 
In Terminal, you may create a branch with the following commands: 
```bash
$ git checkout -b debbie
```

Now you can get started programming! The problems will be labeled as `TODO:`
![Screenshot 2024-09-01 at 3 18 34 PM](https://github.com/user-attachments/assets/1220929f-d869-4082-90a4-8603c6180cd7)

When you have completed your homework assignment, please push the code to your repository! 
If you are using Terminal the commands are:
```bash
$ git status
$ git add .
$ git commit -m "submit homework assignment"
$ git push origin debbie
```
Last but not least, navigate to your repository on GitHub.com and create a new pull request. And assign Debbie (@debbieyuen) and Jerry (jerryxu1999) as **Reviewers**.
![Screenshot 2024-09-01 at 3 29 11 PM](https://github.com/user-attachments/assets/591c0a3b-eb54-4d97-a53d-c1a8535b13d9)


## Credits and References 
This repository of homework assignments was written and created by Debbie Yuen (@debbieyuen) and Jerry Xu (jerryxu1999) for CTIN 583.
