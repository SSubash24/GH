I am working on the AI-Assisted Automation – College Social Network UI Automation Assessment.

Act as a senior QA automation engineer and help me complete this assessment from analysis through automation and execution.

IMPORTANT: Follow the assessment requirements exactly. Do not invent application behavior, element IDs, selectors, validation rules, user stories, expected results, or defects. Use the actual project workspace, application, requirements files, user stories, and observed execution results as the source of truth.

==================================================
1. ASSESSMENT SCOPE
==================================================

The application contains these three modules:

1. Student Registration
2. Update Backlog
3. Add Faculty

All modules require authentication, so create/use one reusable login helper and ensure the required login flow is performed before accessing the modules.

The solution must use the existing workspace/framework structure. Do not unnecessarily replace, restructure, or create redundant project structures.

Use the automation framework already provided in the workspace. If the framework supports Cypress, Playwright, Selenium, JavaScript, TypeScript, Python, Java, C#, or .NET, determine what is actually configured and work with that existing setup.

==================================================
2. FIRST: INSPECT BEFORE GENERATING ANYTHING
==================================================

Before writing test cases or automation code, inspect the complete available workspace and relevant project files.

Pay particular attention to:

- User Stories.txt
- Requirements.txt
- existing automation files
- package/configuration files
- existing page objects
- existing test files
- existing utilities/helpers
- application source/configuration if available

Also inspect the actual application where possible.

Determine and document:

A. Application URL
B. Login flow
C. Login credentials provided by the assessment
D. Navigation path to each module
E. All user stories and their exact requirements
F. All fields in each module
G. Actual HTML element IDs
H. Stable selectors
I. Input types
J. Buttons and controls
K. Validation messages
L. Actual field behavior
M. Mandatory/optional behavior
N. Positive behavior
O. Negative behavior
P. Boundary behavior
Q. Existing automation framework
R. Existing project structure
S. Existing reusable helpers/page objects
T. Anything that is unknown and must be verified manually

Do NOT guess any of the above.

If an element ID, selector, validation rule, or application behavior cannot be verified, explicitly mark it as UNKNOWN and explain how it should be verified.

Create a concise analysis containing:

- Module overview
- Login flow
- Module navigation
- User story mapping
- Field/element mapping
- Validation rules
- Acceptance criteria
- Existing framework analysis
- Verified facts
- Unknowns requiring verification

Do not generate automation code until this inspection is complete.

==================================================
3. ACCEPTANCE CRITERIA
==================================================

Using the actual User Stories.txt and Requirements.txt from the workspace, define acceptance criteria for every user story in scope.

Cover US-01 through US-16 if those are the user stories actually present in this assessment.

For each user story, provide:

- User Story ID
- Module
- Requirement
- Acceptance criteria
- Positive scenario
- Negative/validation scenarios
- Boundary scenarios where applicable
- Relevant fields
- Relevant validation rules

Do not invent acceptance criteria that contradict the supplied requirements.

==================================================
4. VALIDATION RULE ANALYSIS
==================================================

Identify every field-level validation rule for all three modules.

For each field document:

- Field name
- Actual element ID/selector
- Field type
- Mandatory/optional status
- Valid input rule
- Invalid input rule
- Boundary rule
- Expected validation behavior/message if verified

Examples of validation categories to investigate where applicable:

- Empty value
- Invalid format
- Invalid characters
- Incorrect length
- Boundary minimum
- Boundary maximum
- Negative number
- Zero
- Decimal
- Invalid email
- Duplicate/invalid record
- Non-existent record
- Whitespace
- Valid value

Do not assume a validation exists unless it is documented or observed.

==================================================
5. GENERATE TEST CASES
==================================================

After the analysis is verified, create at least 60 detailed test cases covering all user stories and all three modules.

Use exactly these CSV columns:

TC_ID,
Module,
User_Story_ID,
Test_Scenario,
Test_Type,
Priority,
Precondition,
Test_Steps,
Test_Data,
Expected_Result

Test cases must:

- Cover all 16 user stories when US-01 through US-16 exist.
- Cover all three modules.
- Include positive tests.
- Include negative tests.
- Include validation tests.
- Include boundary tests.
- Include mandatory-field tests.
- Include invalid-format tests.
- Include valid-format tests.
- Include meaningful combinations of field validations.
- Include appropriate navigation/precondition requirements.
- Use only documented or verified behavior.

Distribution requirement:

Approximately 60–70% of all test cases must be Negative/Validation scenarios with Critical or High priority.

Boundary scenarios should be Medium priority.

Positive/Success scenarios should generally be Low priority.

Before generating the CSV, calculate and show:

- Total test cases
- Test cases per module
- Test cases per user story
- Positive count
- Negative/Validation count
- Boundary count
- Critical count
- High count
- Medium count
- Low count

Then generate the complete CSV content with correct CSV escaping.

The final file must be:

testcases.csv

==================================================
6. GENERATE AUTOMATION CODE
==================================================

After test cases are defined, create a complete automation solution covering all three modules.

Requirements:

- Use the existing framework.
- Do not change the provided workspace structure unnecessarily.
- Create/use a reusable login helper.
- Create/use page objects or equivalent abstractions appropriate to the existing framework.
- Use actual verified element IDs/selectors.
- Implement at least 20 automated test methods.
- Prioritize Critical and High negative/validation scenarios.
- Use meaningful assertions.
- Assert actual validation behavior rather than merely checking that a button can be clicked.
- Keep tests independent where practical.
- Avoid arbitrary sleeps where proper waits/assertions can be used.
- Avoid brittle selectors when stable verified selectors exist.
- Reuse common functionality.
- Keep code readable and maintainable.

Before creating files, show:

1. Files to create
2. Files to modify
3. Purpose of each file
4. Test-to-user-story mapping
5. Test-to-test-case mapping

Then implement the automation.

Do not fabricate selectors or application behavior.

==================================================
7. VERIFY THE AUTOMATION
==================================================

Save all changes.

Compile/build/install dependencies as required by the existing project.

Run the automation from the integrated VS Code terminal as required by the assessment.

Do not claim tests passed unless they were actually executed.

For every failure, investigate whether it is caused by:

- Incorrect selector
- Incorrect element ID
- Incorrect test data
- Incorrect assertion
- Timing/wait issue
- Navigation issue
- Authentication issue
- Framework issue
- Application behavior
- Actual application defect

Fix automation problems without weakening correct assertions merely to make tests pass.

After each meaningful correction:

1. Save changes.
2. Re-run the affected test.
3. Re-run the broader suite when appropriate.
4. Record the actual result.

==================================================
8. DEFECT IDENTIFICATION
==================================================

Only record defects that are discovered through actual test execution.

IMPORTANT:

Do NOT generate AI-predicted defects.

Do NOT invent defects to reach a required number.

A defect must have:

- Actual test case
- Actual test execution
- Actual input/test data
- Actual observed result
- Documented expected result
- Reproducible behavior

For each confirmed defect, record:

- Defect ID
- Module
- User Story ID
- Test Case ID
- Title
- What was entered
- Steps to reproduce
- Actual result
- Expected result
- Severity
- Priority

The assessment requires at least 8 validation defects across the modules. Attempt to identify them through actual execution, but if fewer than 8 genuine defects exist, do NOT fabricate additional defects.

==================================================
9. CREATE THE REQUIRED DEFECT FILE
==================================================

Create:

defects/defect_report.json

It must contain one consolidated JSON report of confirmed defects from actual execution.

Ensure:

- Valid JSON syntax
- No duplicate defects
- No predicted/fabricated defects
- Each defect contains actual evidence
- Each defect includes entered data, actual result, expected result, severity, and priority

==================================================
10. REQUIRED SUBMISSION FILES
==================================================

Ensure the workspace contains the required deliverables:

1. Application Analysis & Requirements.txt
   - Application analysis
   - Login flow
   - Element IDs/selectors
   - Acceptance criteria
   - Validation rules
   - Findings from inspection

2. testcases.csv
   - At least 60 detailed test cases
   - All required columns
   - All user stories covered
   - Correct negative/validation distribution

3. Automation codebase
   - Shared login helper
   - Page objects/helpers
   - At least 20 automated test methods
   - Tests covering all three modules

4. defects/defect_report.json
   - Consolidated confirmed defects from actual execution

==================================================
11. QUALITY CHECK BEFORE FINISHING
==================================================

Before considering the solution complete, perform a final audit.

Check:

[ ] All three modules are covered.
[ ] All available user stories are covered.
[ ] US-01 through US-16 are covered if they exist.
[ ] Application Analysis & Requirements.txt is complete.
[ ] Actual element IDs/selectors were verified.
[ ] Validation rules were verified.
[ ] Acceptance criteria are documented.
[ ] At least 60 test cases exist.
[ ] Test cases use the exact required CSV columns.
[ ] Approximately 60–70% are Negative/Validation.
[ ] Negative/Validation cases have appropriate Critical/High priority.
[ ] Boundary cases are Medium priority.
[ ] Positive cases are Low priority where appropriate.
[ ] At least 20 automation test methods exist.
[ ] Shared login helper exists.
[ ] All three modules are automated.
[ ] Assertions are meaningful.
[ ] Tests were actually executed.
[ ] Failures were investigated and corrected where appropriate.
[ ] No selectors or requirements were fabricated.
[ ] No defects were fabricated.
[ ] Confirmed defects are based on actual execution.
[ ] defects/defect_report.json is valid.
[ ] Workspace structure has not been unnecessarily changed.
[ ] No redundant files/folders were created.

==================================================
12. FINAL REPORT
==================================================

At the end, provide a concise execution summary containing:

- Modules covered
- User stories covered
- Number of test cases
- Number of automation tests
- Number executed
- Passed
- Failed
- Fixed automation failures
- Confirmed application defects
- Number of validation defects
- Files created/modified
- Remaining issues
- Anything that still requires manual verification

MOST IMPORTANT:

Use verified information from the actual workspace/application.

Never guess.

Never fabricate selectors.

Never fabricate validation rules.

Never fabricate test execution results.

Never fabricate defects.

Do not change correct assertions simply to obtain passing results.

Follow the assessment requirements exactly and keep the implementation focused on the requested College Social Network modules.