properties {
  $testMessage = 'Executed Test!'
  $compileMessage = 'Executed Compile!'
  $cleanMessage = 'Executed Clean!'
}

task default -depends Compile

task Clean { 
  msbuild ../../src/__NAME__.sln /target:Clean
}

task Compile -depends Clean { 
  msbuild ../../src/__NAME__.sln /p:Configuration="Debug"
}

task Test -depends Compile, Clean { 

}



task ? -Description "Helper to display task info" {
	Write-Documentation
}