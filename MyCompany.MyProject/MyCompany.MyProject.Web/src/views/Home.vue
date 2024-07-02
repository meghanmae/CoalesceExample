<template>
  <div class="home">
    <h2>My Events</h2>

    <v-row>
      <v-col v-for="event in events.$items" cols="4" :key="event.$stableId">
        <v-card color="primary">
          <v-card-text> {{ event.name }} </v-card-text>
          <v-btn @click="goToEvent(event.eventId)" color="secondary">
            View Event
          </v-btn>
        </v-card>
      </v-col>
    </v-row>
  </div>
</template>

<script setup lang="ts">
import router from "@/router";
import { EventListViewModel } from "@/viewmodels.g";

useTitle("Home");

const events = new EventListViewModel();
events.$load();

function goToEvent(eventId: string | null) {
  if (eventId !== null) {
    router.push({ name: "EventPage", params: { eventId } });
  }
}
</script>
