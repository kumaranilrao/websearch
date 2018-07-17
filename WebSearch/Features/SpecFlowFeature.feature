Feature: Google Text Search
 
 Scenario: Simple Google search AVIVA Text
    Given I loaded web browser is on the Google page
    When I search text "AVIVA" is entered
    Then results for "AVIVA" are shown

Scenario: Search the AVIVA text and result the 4th link
	Given I loaded web browser is on the Google page
    When I search text "AVIVA" is entered
    And results for "AVIVA" are shown 
	Then the 4th link result shown

Scenario: Search result do not inlcude other link
	Given I loaded web browser is on the Google page
    When I search text "Insurance" is entered
    Then results for "Insurance" are shown
	But the result do not include "Impact"
	 
	