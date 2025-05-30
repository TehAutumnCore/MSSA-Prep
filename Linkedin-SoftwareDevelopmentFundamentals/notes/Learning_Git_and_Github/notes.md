# Learning Git and Github - Introduction
Essential Skill: Version control is crucial for any developer. Git is the most popular version control syste, and github is widely used for collaboration.
Beginner Friendly: The course is designed for beginners, making it easy to grasp the fundamental commands and concepts.
Comprehensive Coverage: It covers key topics like commits, branches, pull requests, and code reviews, which are vital for managing and collaborating on code. 
# Working with Git 
## Understanding version Control
What is Version Control : Allows you to track and manage changes to code over time, enabling you to back up and restore any part of the project's history.
Collaboration: Facilitates teamwork by allowing multiple devloper to work on the same project, share code, and track changes.
Types: of Version Control:
    Centralized: Stores all files and history on a central server(e.g.Apache subversion)
    Distributed: Developers keep copies of the project on their own workstations, making changes locally and then pushing updates to the main repository(e.g. Git.)
## What is Git? 
Version Control System: Git is a version control system that allows you to manage changes to files over time, acting like a historian with a time machine. 
Commits: You can save checkpoints called commits, leaving messages about what happened at each checkpoint.
Branching: Git allows you to create branches, which are alternate versions of your project that you can work on without changing the original. You can merge these branches later.
Setup: To use Git you need to install it from git-scm.com, and may also need a terminal application like GitBash(for windows) or Hyper(for Mac and Windows).

## Setting up Git
Configuration: Use the gitconfig command to set up your username and email ensuring that your contributions are properly credited.
Initialization: Initialize a Git repository in your project folder with the git init command. 
Staging and Committing: Add files to the staging area using git add, and commit them with git commit -m "message" to create checkpoints you can return to later.

## Understanding Git environments
Commit Has: Each commit has a unique ID called a commit hash, which helps track changes. 
Branches: Branches are alternate versions of your project, and the head points to the current branch you're working on. 
File States: Files can be in three environments-- working directory, staging area, and commit history. They can also be tracked (unmodified, staged) or untracked.


## Ignoring Files
Purpose of .git ignore: The .gitignore file is used to specify files and directories that Git should ignore, preventing them from being tracked or uploaded to GitHub.
Common Uses: It's useful fo rexcluding sensitive information like passwords, API keys, and local configuration files (e.g., .DS_Store for macOS, node_modules for NPM Projects)
Implementation: You can create a .gitignore file at the root of your project and list the files or patterns you want to ignore. This helps keep your repository clean and secure. 

## Deleting and renaming files
Deleting Files: You can delete files directory from the file system or use the git rm command. The git rm command automatically stages the deletion. 
Restoring Files: Use git restore to undo deletions. If the deletion was stages, use git restore --staged.
Renaming Files: Rename files using the git mv command, which stages the rename automatcially. Renmaing through the file system will show as a deletion and addition in Git.

## Differences:
using git diff: The git diff command shows differences between files, highlighting changes such as deletions and additions.
Visual Studio Code Integration: Visual Studio Code provides a source control editor to visualize changes, making it easier to manage large changes.
Comparing Commits: You can use git diff to compare different commits and git log --oneline to view a simplified commit history.