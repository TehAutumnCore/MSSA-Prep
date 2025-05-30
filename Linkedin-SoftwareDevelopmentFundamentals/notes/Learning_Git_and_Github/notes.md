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
Configuration: Use the *gitconfig* command to set up your username and email ensuring that your contributions are properly credited.
Initialization: Initialize a Git repository in your project folder with the *git init* command. 
Staging and Committing: Add files to the staging area using *git add*, and commit them with *git commit -m "message"* to create checkpoints you can return to later.

## Understanding Git environments
Commit Has: Each commit has a unique ID called a commit hash, which helps track changes. 
Branches: Branches are alternate versions of your project, and the head points to the current branch you're working on. 
File States: Files can be in three environments-- working directory, staging area, and commit history. They can also be tracked (unmodified, staged) or untracked.


## Ignoring Files
Purpose of .git ignore: The *.gitignore* file is used to specify files and directories that Git should ignore, preventing them from being tracked or uploaded to GitHub.
Common Uses: It's useful fo rexcluding sensitive information like passwords, API keys, and local configuration files (e.g., .DS_Store for macOS, node_modules for NPM Projects)
Implementation: You can create a *.gitignore file* at the root of your project and list the files or patterns you want to ignore. This helps keep your repository clean and secure. 

## Deleting and renaming files
Deleting Files: You can delete files directory from the file system or use the *git rm command*. The git rm command automatically stages the deletion. 
Restoring Files: Use *git restore* to undo deletions. If the deletion was stages, use *git restore --staged*.
Renaming Files: Rename files using the git mv command, which stages the rename automatcially. Renmaing through the file system will show as a deletion and addition in Git.

## Differences:
using git diff: The *git diff* command shows differences between files, highlighting changes such as deletions and additions.
Visual Studio Code Integration: Visual Studio Code provides a source control editor to visualize changes, making it easier to manage large changes.
Comparing Commits: You can use git diff to compare different commits and *git log --oneline* to view a simplified commit history.

## Changing History
Amending commits: Use *git commit --amend* to modify the most recent commit. either by changing the commit message or adding new changes> 
Resetting Commits git reset allows you to move the project back to a previous commit, with options like --soft to keep staged or --hard to discard changes. 
Rebasing git rebase lets you move or combine commits, effectively rewriting the commit history to make it cleaner and more logical.
    Takes the commits from one branch and applies them to another. This can help maintain a clean project and project history.
    if you shouldve made a change earlier in your commit history, you can use *git rebase -i* to move that commit to the correct place.
Squash Commit: This combines the changes from one commit into the previous commit, but keeps both commit messages. Its useful for merging small, related changes into a single commit. 
Fixup commit: Similar to squash, bunt it discards the commit message of the commit being combined. This is useful when you want to clean up your commit history without keeping unnecessary commit messages.

## Branches:
Creating branches: Branches allows you to create different versions of your code to experiment with new features without affecting hte stable version. Use *git switch -c* or the older *git checkout -b* to create a new branch.
Switching and merging: Switch back to the main branch using git switch main and merge changes from your new branch with *git merge <branch-name>*
delete the branch you no longer need with *git branch -d <branch-name>* to keep your repository clean.
Git Flow: The typical workflow involves creating a new branch for features or fixes, making changes, merging back to the main branch, and then deleting the feature branch. This helps manage collaboration and maintain a clean project history.

## Merge Conflicts
Understanding Merge Conflicts: Merge conflicts occur when changes are made to the same part of a file in different branches. These conflicts need to be resolved manually.
Resolving Conflicts: Use Visual Studio Code or another editor to choose which changers to keep. The editor will highlight ocnflicts and provide options ot accept changes from either branch.
Practical Steps: The video demonstrates how to create a conflict, switch between branches, and resolve the conflict by editing the file and committing the changes.
    *Commands Used*
    `git switch` -c <branch-name>: Creates and switches to a new branch.
    `git add` .: Stages all changes in the current directory.
    `git commit` -m "<message>": Commits the staged changes with a message.
    `git switch` <branch-name>: Switches to the specified branch.
    `git merge` <branch-name>: Merges the specified branch into the current branch.
    `git status`: Shows the status of the working directory and staging area.
    `git log` --oneLine: Displays the commit history in a simplified format.
    `git commit` --amend: Amends the last commit with new changes.

## Git Stash and clean:
Git Stash: Temporarily stores changes that are not yet ready to be committed, allowing you to work on something else without losing your progress. Commands include *git stash*, *git stash list*, g*it stash apply*, and *git stash pop*.
    *git stash*:Temporarily stores changes you've made to your working directory so you can work on something else without losing your progress. It's like putting your changes on hold.
    *git stash list*: Displays a list of all stashed changes. Each stash is indexed, starting from zero.
    *git stash apply*: Applies a specific stash from the list to your working directory without removing it from the stash list. 
    *git stash pop*: Applies the most recent stash and removes it from the stash list. 
Git Clean: Removes untracked files and directories from your working directory. Useful for cleaning up unnecessary files. Commands include *git clean -n*(dry run) and *git clean -df* (force delete directories and files)
    *git clean*: Removes untracked files from your working directory. Use -n to preview what will be removed, -d to include directories, and -f to force the removal.

# Working with Github
## What is GitHub
Github as a Collaborative Platform: GitHub is an online service that lalows developers to work together on code, providing tools for tracking changes, assigning issues, and managing changes.
Setting Up a Repository: To use GitHub you need to create a repository and link it to your local repository and link it to your local repository. This involves setting up a remote, pushing changes, and fetching updates.
Project Management Tools: GitHub offers project management features like KanBan boards, issue tracking, and more, which help in organizing and managing development projects.

## Pushing to GitHub
Adding Remotes: Use the *git remote add <name> <URL>* command to connect your local project to a remote repository on GitHub. The common name for the remote is origin.
Pushing Changes: The *git push* command is used to upload your local changes to the remote repository. use *git push -u <remote> <branch>* to set the upstream branch for the first push.
Managing Remotes: You can list (*git remote-v*), remove(*git remote remove <name>*), and rename (git remote rename <old-name> <new-name>) remotes as needed.

## GitHub options
