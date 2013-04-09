properties {  
  $projectName = '__NAME__'
  $configuration = 'Release'  
  $solutionFile = resolve-path ../../src/$projectName.sln
  $xunitToolsPath = resolve-path ../../tools/xunit-1.9.1/xunit.console.clr4.exe
  $unitTestProject = resolve-path ../../src/$projectName.UnitTests/bin/$configuration/$projectName.UnitTests.dll
}

task default -depends Compile

task Clean { 
	exec {
		msbuild $solutionFile /target:Clean /v:quiet
	}
}

task Compile -depends Clean { 
	exec { 
		msbuild $solutionFile /p:Configuration="$configuration" /v:quiet
	}
}

task Test -depends Compile, Clean { 
	exec {
		& $xunitToolsPath $unitTestProject /nunit results.xml
	}
}



task ? -Description "Helper to display task info" {
	Write-Documentation
}