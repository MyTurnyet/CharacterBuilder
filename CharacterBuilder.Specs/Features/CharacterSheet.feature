Feature: CharacterSheet
	A Character Sheet for CharacterBuilder

Scenario: CharacterSheet should return the correct JSON
	Given a Wood Elf
	And the class of Fighter
	And Attributes of Strength 10
	And Attributes of Dexterity 10
	And Attributes of Intelligence 10
	And Attributes of Wisdom 10
	And Attributes of Charisma 10
	And Attributes of Constitution 10
	When the Character is created
	Then the JSON output will be correct