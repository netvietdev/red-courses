To restore Bower components during build, add the next line to the project pre-build events:

"$(SolutionDir)packages\Bower.1.2.7.4\bower.cmd" install

Or use custom .cmd file and run it after `git pull` and on the build server:

@echo off
cmd.exe /c "@echo off & cd %~dp0 & %~dp0..\packages\Bower.1.2.7.4\bower.cmd install"