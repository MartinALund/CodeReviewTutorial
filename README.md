# CodeReviewExample


# Fork this repository
When you fork a repository, you create a copy of a repository. So forking this project will give you your own version of it.

- Click on the small fork image on the top of this page
- Congratulations! You now have a copy of this repository on your own git account
- From now on, all changes in this tutorial will be on your forked repository

# Add collaborators to forked project
- Go to the `Settings` tab
- Go to `Collaborators`
- Add your team members here

# Add collaborators to CODEOWNERS file
- Go to the `Code` tab
- Click on the CODEOWNERS file
- Edit this file by clicking on the pencil
- Add your team members on line 2 with the syntax @membername @membertwo
- Scroll down to the bottom
- Make sure 'Commit directly to the master branch' is checked. 
- Click 'Commit changes' to update the file


# Add branch rules to forked project
- Go to the `Settings` tab
- Go to `Branches`
- Click on `Add rule`
- Write "master" as 'Branch name pattern' 
- Check the 'Require pull request reviews before merging' 
- Check the 'Include administrators' 
- Click `Create` in the bottom

# Clone repository to your local machine
- Go to the `Code` tab
- Click on the 'Clone or download' button
- Grab the url
- Git clone the project by opening git bash where you want to clone the project, and type in `git clone https://github.com/YOUR-USERNAME/CodeReviewExample.git`
- When you clone the project remember to add origin to your project by doing `git remote add origin https://github.com/YOUR-USERNAME/CodeReviewExample.git`
- If you are using a git gui like `Github Desktop` you can clone directly from that program.

You now have the project working locally on your machine. Now we can make changes to the code.


# Make changes to project locally

When making changes to code, you should always branch out and create changes on that branch.
Before creating a branch, you should always do a pull from master, to ensure you have the newest version when branching out.

### Git bash:
- Open git bash where your project is and type `git pull` to get the newest version from master. 
- Type in `git checkout -b [name_of_your_new_branch]` this will create a new branch and switch to that branch

You now have a branch and are able to make changes in your branch. Make some changes to the code and proceed

- Type in `git status` to check which branch you are on
- If you are adding a new file, remember to type in `git add 'filename'`
- Type in `git commit -m "[Commit Message]"` to commit your changes
- Type in `git pull origin master` to pull changes from master into your branch
- Type in `git push -u origin [name_of_your_new_branch]`


### Git gui: 
- Make a pull from master
- Create a new branch and checkout that branch 

You now have a branch and are able to make changes in your branch. Make some changes to the code and proceed

- Add the files you need from the gui
- Commit changes and add a commit message
- Pull master into your branch.
- Push your changes to the branch

# Create the pull request

You have now made some changes, and you want your changes to appear on the master branch.

- Navigate to github.com and find your repository. 
- Click on the tab 'Pull requests'
- Click on 'New pull request' 
- Set your 'base' to master and 'compare' to your branch - Remember to set the base as your forked repository and not where you forked the repository from. 
- Click on 'Create pull request'
- Fill in information about the pull request, what you have done.
- Click on 'Create pull request' 

Your pull request is now available on the branch.
If you have setup codeowners they will recieve an email about this pull request. This pull request now needs to be reviewed by one of the codeowners, and this is where we begin working with code reviews. 


# Submit review to a pull request
- Navigate to your repository on Github
- Click on the tab 'Pull requests'
- Click on the pull request you want to review
- Click on 'Add your review'

Now it is time for your code review.
You can create comments on a line by hovering over the line, and clicking the + sign that pops up.

When you are ready to finish the review click on 'Review changes'
- `Comment` = Create a general comment about the pull request, if you are wondering about something before approving
- `Approve` = Pull request is accepted, and is ready to be merged into master
- `Request changes` = Submit some feedback about what should be changed before the change is ready to master.

Let's say the pull request is approved and ready for master. Who should merge it?
In our team the requester of the pull request gets to merge into master.

In your pull request click on the 'Merge pull request' button when you have green lights, confirm merge and you are done!
If you don't need the branch anymore you can click on the 'Delete branch' button.

# What's in it for me?

Working this way with GIT requires practice but it sets you up for the real world and code review.

Benefits of code review:
- Catch bugs in the software before releasing it into master
- The team is in focus, when releasing code with code review, you get a sense of teamwork over it. You are never alone on releasing code
- You learn by either receiving or giving a code review
-If you want to contribute to open source projects a `fork` + `pull request` based GIT strategy is not uncommon

### The end
You have now forked a repository, and made some changes. This tutorial is not about the actual code in the repository you are forking, but about this way of working with GIT. The next time you are working in a team, try enforcing this way of using GIT and code review.



