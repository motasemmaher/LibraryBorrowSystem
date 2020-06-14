# LibraryBorrowSystem
Problem Description: High School Library System

A high school has decided to create a library system to allow its students and teachers to borrow library items
like books and CDs.
The system shall keep a complete list of all items and their details including number, category, availability, and
expected return date. Students and teachers can request an unavailable item by going into that item waiting list. Once
an item is returned, the system shall send the first student/teacher on that item waiting list a text message to indicate
this item availability. The system should keep this reserved item for one day (24x60 minutes) by default to allow the
person that reserve that item to check it out. If this item is not checked out, the system can then send text message to
the next person in the waiting list or make the item available.
Each student can borrow up to three items (by default) at the same times while teachers can borrow up to six
items (by default). If an item is not returned on time (5x24x60 minutes = 5 days by default), the system sends a text
message to the item holder. If the item is not returned by two days (2x24x60 minutes) by default, the item holder
will be charged three times (by default) the book actual price and a text message is sent to the item holder.
The librarian can at any time view the list of all of the late items, view a specific teacher borrowed items (late
items shown in red), or view a specific student borrowed items (late items shown in red).
The system shall keep all previous transactions history for each item, student, and teacher. The system should
also allow the librarian to add more items to the system (and to remove damaged or not returned items from the
system). 
