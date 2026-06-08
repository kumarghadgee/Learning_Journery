# Linux File Handling Commands - Structured Notes

## 1. Introduction

Linux provides a set of commands to create, view, modify, copy, move, and delete files and directories. These commands form the foundation of everyday Linux administration and are frequently asked in practical exams and interviews.

---

# 2. Navigating the File System

## pwd (Print Working Directory)

Displays the current directory path.

```bash
pwd
```

Example:

```text
/home/pranav
```

---

## ls (List Files and Directories)

Lists files and directories in the current location.

```bash
ls
```

Detailed view:

```bash
ls -l
```

Show hidden files:

```bash
ls -a
```

---

## cd (Change Directory)

Move between directories.

```bash
cd Documents
```

Go to parent directory:

```bash
cd ..
```

Go to home directory:

```bash
cd ~
```

---

# 3. Creating Files and Directories

## touch

Creates an empty file.

```bash
touch file1.txt
```

Create multiple files:

```bash
touch file1.txt file2.txt file3.txt
```

---

## mkdir (Make Directory)

Create a directory.

```bash
mkdir test
```

Create multiple directories:

```bash
mkdir one two three
```

Create nested directories:

```bash
mkdir -p one/two/three
```

---

# 4. Viewing and Editing File Content

## cat

Display file contents.

```bash
cat file1.txt
```

Create or overwrite a file:

```bash
cat > file1.txt
```

After entering text, press:

```text
Ctrl + D
```

Append content:

```bash
cat >> file1.txt
```

---

# 5. Copying Files and Directories

## cp

Copy a file.

```bash
cp file1.txt file2.txt
```

Copy a file to another directory:

```bash
cp file1.txt Documents/
```

Copy an entire directory:

```bash
cp -r dir1 dir2
```

---

# 6. Moving and Renaming Files

## mv

Rename a file:

```bash
mv old.txt new.txt
```

Move a file:

```bash
mv file1.txt Documents/
```

Move and rename simultaneously:

```bash
mv file1.txt Documents/newfile.txt
```

---

# 7. Deleting Files and Directories

## rm

Delete a file:

```bash
rm file1.txt
```

Delete multiple files:

```bash
rm file1.txt file2.txt
```

Delete a directory and its contents:

```bash
rm -r mydir
```

---

## rmdir

Delete an empty directory.

```bash
rmdir test
```

---

# 8. Useful File Handling Commands

## head

Display the first few lines of a file.

```bash
head file.txt
```

---

## tail

Display the last few lines of a file.

```bash
tail file.txt
```

---

## wc

Count lines, words, and characters.

```bash
wc file.txt
```

---

## grep

Search for text inside a file.

```bash
grep "Java" file.txt
```

---

## clear

Clear the terminal screen.

```bash
clear
```

---

# 9. Complete Practice Session

```bash
mkdir Linux
cd Linux

touch notes.txt

cat > notes.txt
Linux Commands
Ctrl + D

cat notes.txt

cp notes.txt backup.txt

mv backup.txt newbackup.txt

ls

rm newbackup.txt
```

---

# 10. Quick Revision Table

| Command | Purpose |
|----------|----------|
| pwd | Show current directory |
| ls | List files and directories |
| cd | Change directory |
| touch | Create file |
| cat | View/Create/Edit file |
| mkdir | Create directory |
| cp | Copy files/directories |
| mv | Move or rename files |
| rm | Delete files |
| rmdir | Delete empty directory |
| head | View first lines |
| tail | View last lines |
| wc | Count lines, words, characters |
| grep | Search text |
| clear | Clear terminal |

---

# Interview Summary

Linux file handling commands are used to create, view, copy, move, rename, and delete files and directories. Important commands include `pwd`, `ls`, `cd`, `touch`, `cat`, `cp`, `mv`, `rm`, `mkdir`, and `rmdir`.
