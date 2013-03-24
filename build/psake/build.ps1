properties {  
  $projectName = '__NAME__'
  $configuration = 'Release'  
}

task default -depends Compile

task Clean { 
	exec {
		msbuild ../../src/$projectName.sln /target:Clean /v:quiet
	}
}

task Compile -depends Clean { 
	exec { 
		msbuild ../../src/$projectName.sln /p:Configuration="$configuration" /v:quiet
	}
}

task Test -depends Compile, Clean { 
	exec {
		../../tools/xunit-1.9.1/xunit.console.clr4.exe ../../src/$projectName.UnitTests/bin/$configuration/$projectName.UnitTests.dll /nunit results.xml
	}
}



task ? -Description "Helper to display task info" {
	Write-Documentation
}