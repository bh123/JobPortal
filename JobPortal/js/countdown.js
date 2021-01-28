//  ====================================================================
//	Theme Name: Jober - Multi-purpose Bootstrap Template
//	Theme URI: http://themeforest.net/user/responsiveexperts
//	Description: This javascript file is using as a settings file. This file includes the sub scripts for the javascripts used in this template.
//	Version: 1.0
//	Author: Responsive Experts
//	Author URI: http://themeforest.net/user/responsiveexperts
//	Tags:
//  ====================================================================

//	TABLE OF CONTENTS
//	---------------------------
//	 01. Countdown

//  ====================================================================



(function($) {
	"use strict";
	setInterval(function(){
		var future = new Date("July 22 2022 4:30:10 GMT+0200");  // date to count down
		var now = new Date();
		var difference = Math.floor((future.getTime() - now.getTime()) / 1000);
		
		var seconds = fixIntegers(difference % 60);
		difference = Math.floor(difference / 60);
		
		var minutes = fixIntegers(difference % 60);
		difference = Math.floor(difference / 60);
		
		var hours = fixIntegers(difference % 24);
		difference = Math.floor(difference / 24);
		
		
		var days = difference;
		
		$("#seconds").text(seconds);
		$("#minutes").text(minutes);
		$("#hours").text(hours);
		$("#days").text(days);
		
	}, 1000);
	
	function fixIntegers(integer)
	{
		if (integer < 0)
			integer = 0;
		if (integer < 10)
			return "0" + integer;
		return "" + integer;
	}
})(jQuery);