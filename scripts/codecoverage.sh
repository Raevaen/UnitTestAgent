# Restore and Test
dotnet restore
dotnet test --collect:"XPlat Code Coverage"

# Find Coverage File
COVERAGE_FILE=$(find . -name "coverage.cobertura.xml")

# Extract Line and Branch Coverage
LINE_COVERAGE=$(grep '<coverage ' $COVERAGE_FILE | sed 's/.*line-rate="\([^"]*\)".*/\1/')
BRANCH_COVERAGE=$(grep '<coverage ' $COVERAGE_FILE | sed 's/.*branch-rate="\([^"]*\)".*/\1/')

# Convert to Percentages
LINE_COVERAGE_PERCENT=$(echo "$LINE_COVERAGE * 100" | bc)
BRANCH_COVERAGE_PERCENT=$(echo "$BRANCH_COVERAGE * 100" | bc)

# Output Results
echo "Line Coverage: $LINE_COVERAGE_PERCENT%"
echo "Branch Coverage: $BRANCH_COVERAGE_PERCENT%"
