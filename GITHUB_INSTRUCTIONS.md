# GitHub Repository Setup Instructions

## Prerequisites
1. Git installed on your system
2. GitHub account
3. GitHub CLI (optional but recommended)

## Option 1: Using GitHub CLI (Recommended)

1. Install GitHub CLI from https://cli.github.com/
2. Authenticate with GitHub CLI:
   ```
   gh auth login
   ```
3. Run the provided script:
   ```
   .\push-to-github.ps1
   ```
   or
   ```
   .\push-to-github.bat
   ```

## Option 2: Manual Setup

1. Go to https://github.com/new
2. Create a new repository named "CourseraGradedProjects"
3. DO NOT initialize with README, .gitignore, or license
4. Run these commands in your project directory:
   ```
   cd c:\Users\pandr\OneDrive\Desktop\CourseraGradedPRojs
   git remote add origin https://github.com/Blazehue/CourseraGradedProjects.git
   git branch -M main
   git push -u origin main
   ```

## Verification

After pushing, visit https://github.com/Blazehue/CourseraGradedProjects to verify:
1. All files have been uploaded
2. Commit history is preserved (25+ commits)
3. Contributions are counted correctly

## Troubleshooting

If you encounter authentication issues:
1. Use HTTPS with username/password (not recommended)
2. Set up SSH keys for secure authentication
3. Use GitHub Personal Access Tokens for HTTPS authentication

For more information, visit: https://docs.github.com/en/authentication