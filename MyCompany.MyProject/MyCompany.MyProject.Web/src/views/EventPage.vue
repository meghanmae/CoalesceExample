<template>
  <c-loader-status :loaders="[event.$load, event.$save]" no-initial-content>
    <h2>
      {{ event.name }}
    </h2>

    <v-row>
      <v-col>
        <c-input :model="event" for="name" />
      </v-col>
      <v-col>
        <c-input :model="event" for="start" />
      </v-col>
      <v-col>
        <c-input :model="event" for="end" />
      </v-col>
    </v-row>

    <v-chip>
      {{ formatDate(event.start) }} - {{ formatDate(event.end) }}
    </v-chip>
  </c-loader-status>
</template>

<script setup lang="ts">
import { EventViewModel } from "@/viewmodels.g";
import { format } from "date-fns";

const props = defineProps<{ eventId: string }>();

const event = new EventViewModel();
event.$load(props.eventId);
event.$useAutoSave();

function formatDate(date: Date | null) {
  if (date !== null) {
    return format(date, "eeee, MMMM do, yyyy h:mm a");
  }
  return "Not Set";
}
</script>
